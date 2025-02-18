﻿

namespace RootsApp
{
    class Root : IRoot
    {
        public double root;
        public int error;

        double IRoot.Root { get => root; set => root = value; }
        int IRoot.Error { get => error; set => error = value; }

        public override string ToString()
        {
            if (error == (int)Errors.ROOT_ERRORS.NONE)
            {
                return root.ToString();
            }
            else
            {
                return "Root Not Found: Error " + error;
            }
        }

        public Root()
        {
            error = (int)Errors.ROOT_ERRORS.NONE;
        }

        public Root(double r)
        {
            root = r;
            error = (int)Errors.ROOT_ERRORS.NONE;
        }
    }
}
