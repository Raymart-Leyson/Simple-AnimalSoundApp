using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    /// <summary>
    /// [Inheritance]
    /// Inherit the methods of Animal
    /// </summary>
    internal class Cat : Animal
    {
        /// <summary>
        /// [Encapsulation]
        /// It Encapsulate the private class and only the getters and setter can access that object
        /// </summary>
        private string _voice;
        public Cat(string voice)
        {
            _voice = voice;
        }
        public void setVoice(string voice)
        {
            _voice = voice;
        }
        public string voice
        {
            set { _voice = value; }
            get { return _voice; }
        }
        /// <summary>
        /// [Inheritance]
        /// It implements the sound methods from the Animal
        /// <returns>a string with the cat voice</returns>
        public override string sound()
        {
            return voice;
        }
    }
}
