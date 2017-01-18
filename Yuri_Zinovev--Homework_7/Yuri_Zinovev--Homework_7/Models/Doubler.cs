using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Doubler
    {
        public int Current { get; private set; }
        public int Goal { get; set; }
        public int ActionsCounter { get; private set; }

        bool _changes = false;
        int _prevCurrent;
        int PrevCurrent
        {
            get
            {
                return _prevCurrent;
            }
            set
            {
                _changes = true;
                _prevCurrent = value;
            }
        }

        public DoublerState State
        {
            get
            {
                var delta = (Goal - Current);

                if (delta == 0)
                {
                    return DoublerState.Victory;
                }

                if (delta < 0)
                {
                    return DoublerState.Defeat;
                }

                return DoublerState.InProgress;
            }
        }

        public Doubler()
        {
            Current = 1;
        }
        public Doubler(int goal)
            : this()
        {
            Goal = goal;
        }

        public void PlusOne()
        {
            PrevCurrent = Current;
            Current++;
            ActionsCounter++;
        }

        public void Double()
        {
            PrevCurrent = Current;
            Current *= 2;
            ActionsCounter++;
        }

        public void ResetToOne()
        {
            PrevCurrent = Current;
            Current = 1;
            ActionsCounter++;
        }

        public bool CanReturnState()
        {
            return _changes;
        }

        public void ReturnState()
        {
            if (ActionsCounter == 0)
            {
                return;
            }
            _changes = false;
            Current = PrevCurrent;
            ActionsCounter++;
        }
    }

    public enum DoublerState
    {
        InProgress,
        Victory,
        Defeat
    }
}
