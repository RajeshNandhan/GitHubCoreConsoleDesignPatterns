using System.Collections.Generic;

namespace CreationalPatterns.Singleton
{
    internal class ProductCreaterSingleton
    {
        //No A Step - custom bussiness requirement - not realy a design pattern concern here
        public Mobile Mobile
        {
            get;
            set;
        }

        public IPod IPod
        {
            get;
            set;
        }

        public Laptop Laptop
        {
            get;
            set;
        }



        // Step 1 - Private memeber
        static ProductCreaterSingleton instance;

        // Step 2 - Lock synchronization object for singleton instance creation
        private static object locker = new object();

        // Step 3 - Constructor (protected) - so no access from outside for instance creation, every time you call this constructor objectcreated but in sinlgeton only one call
        protected ProductCreaterSingleton()
        {
            Mobile = new Mobile();
            IPod = new IPod();
            Laptop = new Laptop();
        }

        //Step 4 - Assures only a single instance object (the singleton) of the class can be created
        public static ProductCreaterSingleton CreateandGetSingleInstanceOfProductCreaterSingletonObject()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ProductCreaterSingleton();
                    }
                }
            }
            return instance;
        }
    }
}
