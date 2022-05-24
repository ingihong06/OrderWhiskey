using System.Collections;

namespace Distillery
{
    // 클래스 WhiskeyFactory : 클래스 Distillery의 메소드 createDistillation(), registerDistillation()을 구현하고 있는 메소드
    public class WhiskeyFactory : Distillery
    {
        private ArrayList whiskey = new ArrayList();
        protected override Distillation createDistillation(string whiskeyName)
        {
            return new Whiskey(whiskeyName);
        }
        protected override void registerDistillation(Distillation distillation)
        {
            whiskey.Add(((Whiskey)distillation).getwhiskeyName());
        }
        public ArrayList getwhiskeyName()
        {
            return whiskey;
        }
    }
}
