using Banking.Cqrs.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Cqrs.Core.Domain
{
    public abstract class AggregateRoot
    {
        public string Id { get; set; } = string.Empty;
        public int version = -1;
        List<BaseEvent> changes = new List<BaseEvent>();


        public int getVersion() {
            return version;
        }

        public void SetVersion(int version)
        {
            this.version = version;
        }

        public List<BaseEvent> GetUncommitedChanges() { 
            return changes;
        }

        public void MarkChangesAsCommited() { 
            changes.Clear();
        }

        public void ApplyChanges(BaseEvent @event, bool isNewEvent) {
            try {
                var ClassEvent = @event.GetType();
                var method = GetType().GetMethod("Apply", new[] { ClassEvent });
                method.Invoke(this, new object[] { @event });

            }catch(Exception e) { 
            } finally { 
                if(isNewEvent)
                {
                    changes.Add(@event);
                }
            }
        }

        public void RaiseEvent(BaseEvent @event) { 
            ApplyChanges(@event, true);
        }

        public void ReplayEvents(IEnumerable<BaseEvent> events) {
            foreach (var evt in events) { 
                ApplyChanges(evt, false);
            }
        }
    }
}
