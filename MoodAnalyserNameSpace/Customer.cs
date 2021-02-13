using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserNameSpace
{
    class Customer
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int id
        {
            get; set;
        }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name
        {
            get; set;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        /// <summary>
        /// Initializes a new instance 
        /// </summary>
        public Customer()
        {
            this.id = -1;
            this.name = string.Empty;
        }
        /// <summary>
        /// Prints the identifier.
        /// </summary>
        public void PrintId()
        {
            Console.WriteLine("Id is " + this.id);
        }
        /// <summary>
        /// Prints the name.
        /// </summary>
        public void PrintName()
        {
            Console.WriteLine("Name is " + this.name);
        }
    }
}
