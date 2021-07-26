using System;
using System.Collections.Generic;
namespace RealPF
{
    class Program
    {
        public int NUMBER_OF_SHARKS;
        public int NUMBER_OF_ROBOTS;
        public int NUMBER_OF_PARTICLEFILTERS;
        public List<ParticleFilter> particleFilterList = new List<ParticleFilter>();
        public void create_real_range_list()
        {
            //updates real_range_list
            foreach(Shark s1 in MyGlobals.shark_list)
            {
                List<double> newList = new List<double>();
                foreach(Robot r1 in MyGlobals.robot_list)
                {
                    newList.Add(s1.calc_range_error(r1));
                }
                MyGlobals.real_range_list.Add(newList);
            }
        }
        public void create_and_initialize_sharks()
        {
            int SharkIndex = 0;
            for(int i=0; i<NUMBER_OF_SHARKS; ++i)
            {
                Shark s1 = new Shark();
                s1.SHARKNUMBER = SharkIndex;
                MyGlobals.shark_list.Add(s1);
                SharkIndex += 1;
            }
        }
        public void create_and_initialize_robots()
        {
            int RobotIndex = 0;
            for (int i = 0; i < NUMBER_OF_ROBOTS; ++i)
            {
                Robot r1 = new Robot();
                r1.ROBOTNUMBER = RobotIndex;
                MyGlobals.robot_list.Add(r1);
                RobotIndex += 1;
            }
        }

        public void create_and_initialize_particle_filter()
        {
            for (int i = 0; i < NUMBER_OF_PARTICLEFILTERS ; ++i)
            {
                ParticleFilter p1 = new ParticleFilter();
                particleFilterList.Add(p1);
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
