using System;

namespace mvvmlight1.Droid
{
    public static class App
    {
        private static ViewModelLocator locator;

        public static ViewModelLocator Locator => locator ?? (locator = new ViewModelLocator());
    }
}

