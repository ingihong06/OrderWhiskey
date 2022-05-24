using System;

namespace Distillery
{
    // Distillery : 메소드 create()를 구현하고 있는 추상클래스
    public abstract class Distillery
    {
        public Distillation create(String whiskeyName)
        {
            Distillation d = createDistillation(whiskeyName);
            registerDistillation(d);
            return d;
        }
        protected abstract Distillation createDistillation(String whiskeyName);
        protected abstract void registerDistillation(Distillation distillation);
    }
}
