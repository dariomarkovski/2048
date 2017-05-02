using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    public class Game
    {
        private State state;
        private List<State> lastState;
        private int numberAvailableUndos;
        private string mode;

        public Game()
        {
            state = new State();
            lastState = new List<State>();
            mode = "normal";
            numberAvailableUndos = 0;
        }

        public Game(string _mode)
        {
            state = new State();
            lastState = new List<State>();
            mode = _mode;
            if (mode.Equals("normal"))
                numberAvailableUndos = 0;
            else if (mode.Equals("ultimate"))
                numberAvailableUndos = 1;
            else if (mode.Equals("practice"))
                numberAvailableUndos = 5;
        }
        public Game(string savedMode, string savedGame)
        {
            state = new State(savedGame);
            mode = savedMode;
            lastState = new List<State>();
            if (savedMode.Equals("normal"))
                numberAvailableUndos = 0;
            else if (savedMode.Equals("ultimate"))
                numberAvailableUndos = 1;
            else if (savedMode.Equals("practice"))
                numberAvailableUndos = 5;
        }
        public string [][] getState()
        {
            return state.matrix;
        }

        public void updateState(string key)
        {
            if (numberAvailableUndos != 0)
            {
                if (lastState.Count == numberAvailableUndos) lastState.RemoveAt(0);
                lastState.Add(new State(state));
            }
            state.move(key);
        }
        public void undoMove()
        {
            state = lastState[lastState.Count - 1];
            lastState.RemoveAt(lastState.Count - 1);
        }
        public bool canUndo()
        {
            return lastState.Count > 0 ? true : false;
        }

        public void saveGame()
        {
            if (!state.isFinished())
            {
                Properties.Settings.Default.savedGame = true;
                Properties.Settings.Default.savedString = state.getStringFormat();
                Properties.Settings.Default.savedMode = mode;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.savedGame = false;
                Properties.Settings.Default.savedString = state.getStringFormat();
                Properties.Settings.Default.savedMode = "";
                Properties.Settings.Default.Save();
            }
        }

        internal bool isFinished()
        {
            return state.isFinished();
        }
    }
}
