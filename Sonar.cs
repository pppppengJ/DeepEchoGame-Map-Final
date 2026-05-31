using System;
using System.Collections.Generic;
using System.Text;

namespace DeepEchoGame
{
    class Sonar
    {
        private Map map;

        public Sonar(Map map)
        {
            this.map = map;
        }

        public void Scan(int index) //구역의 몬스터 존재 스캔
        {
            if (index < 1 || index > map.Zones.Count)
            {
                Zone target = map.Zones[index - 1];

                Console.WriteLine("=== 소나 스캔 ===");

                if (target.HasMonster)
                    Console.WriteLine($"[{target.Name}] : 위협적인 반응이 감지됩니다.");
                else
                    Console.WriteLine($"[{target.Name}] : 외부 반응이 느껴지지 않습니다.");
            }
            // 못 찾았을 때
            else
            {
                Console.WriteLine("존재하지 않는 구역입니다. 다시 시도해 주세요.");
                return;
            }
        }
    }
}
