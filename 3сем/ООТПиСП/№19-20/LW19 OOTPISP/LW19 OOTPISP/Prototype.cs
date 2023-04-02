﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __19_20_Применение_структурных_и_паттернов_поведения
{
    abstract class Prototype
    {
        public int Id { get; private set; }
        public Prototype(int id)
        {
            this.Id = id;
        }
        public abstract Prototype Clone();
    }

    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id)
            : base(id)
        { }
        public override Prototype Clone()
        {
            return new ConcretePrototype1(Id);
        }
    }

    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id)
            : base(id)
        { }
        public override Prototype Clone()
        {
            return new ConcretePrototype2(Id);
        }
    }
}
