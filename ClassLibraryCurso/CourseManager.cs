using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCurso
{
    public class CourseManager
    {
        private readonly Course[] cursos;
        int currentIndex = 0;
        private readonly int lastIndex;

        public CourseManager()
        {
            cursos = initCourses();
            lastIndex = cursos.Length - 1;
        }

        private Course[] initCourses()
        {
            var initcourses = new Course[] {
                    new Course()
                    {
                    Title = "Android for .NET Developers",
                    Description = "Provides an overview of the tools used in the Android " +
                    "development process including the newly released Android Studio.",
                    Image = "ps_top_card_01"
                    },

                    new Course()
                    {
                    Title = "Android Dreams, Widgets, Notifications",
                    Description = "Provide users with a rich and interactive experience " +
                    "without ever requiring them to open your app.",
                    Image = "ps_top_card_02"
                    },
                    new Course()
                    {
                    Title = "Android Photo/Video Programming",
                    Description = "Learn how to capitalize on the Android camera " +
                    "within your apps to capture still photos and video.",
                    Image = "ps_top_card_03"
                    },
                    new Course()
                    {
                    Title = "Android Location-Based Apps",
                    Description = "Cover the wide range of Android location capabilities " +
                    "including determining user location, power management, and " +
                    "translating location data to human-readable addresses.",
                    Image = "ps_top_card_04"
                    }

            };
            return initcourses;
        }

        public void moveFirst()
        {
            currentIndex = 0;   
        }
        public void movePrev()
        {
            if (currentIndex > 0)
                --currentIndex;
        }
        public void moveNext()
        {   
            if(currentIndex< lastIndex)
                 ++currentIndex;  
        }

        public Course Current
        {
            get { return cursos[currentIndex]; }
            //get { return cursos[currentIndex]; } 
        }

        public Boolean canMovePrev
        {
            get { return (currentIndex > 0); }  
        }

        public Boolean canMoveNext
        {
            get { return (currentIndex < lastIndex); }
        }
    }
}
