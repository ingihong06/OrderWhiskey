using System;

namespace Distillery
{
    // 클래스 Whiskey : 클래스 Distillation의 메소드 drink() 를 구현하고 있는 클래스
    public class Whiskey : Distillation
    {
        private string whiskeyName; 
        public Whiskey(String whiskeyName)
        {
            Console.WriteLine(whiskeyName + "을(를) 잔에 따릅니다");
            this.whiskeyName = whiskeyName;
        }
        public override void drink()
        {
            Console.WriteLine(whiskeyName + "을(를) 마십니다");
        }
        public String getwhiskeyName()
        {
            return whiskeyName;
        }
    }
}
