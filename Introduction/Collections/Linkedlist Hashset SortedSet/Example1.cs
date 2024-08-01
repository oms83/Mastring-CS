using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.Collections.Linkedlist_Hashset_SortedSet
{
    /*
        linkedlist
        - fast remove/retrieval
        - kept in memory after processing
        - sequentail access

        hashset & sortedset
        - fast remove/retrieval
        - kept in memory after processing
        - Random access
        - Contiguous memory
        
        hashset
            - hash based lookups الفهرسة
            - stores key only يخزن مفاتيح فقط
            - no duplication لا تكرار
            - no indexing لا فهرسة
        
        sortedset
            - no duplication 
            - no indexing
            - keeps elements in order
            - slower then hashset

        play list -> linkedlist
        undo&redo -> stack
        printing  -> queue
        
        
     */

    public class YTVideo
    {
        public YTVideo(string iD, string title, TimeSpan duration)
        {
            ID = iD;
            Title = title;
            Duration = duration;
        }

        public string ID { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }

        public override string ToString()
        {
            // https://www.youtube.com/watch?v=jaRYL5iHXRM

            return $"|--{Title} ({Duration})\n|\thttps://www.youtube.com/watch?v={ID}";
        }
    }

    public class Example1
    {
        public static void run()
        {
            var video1 = new YTVideo("OMSV1", "lesson 1", new TimeSpan(00, 02, 44));
            var video2 = new YTVideo("OMSV2", "lesson 2", new TimeSpan(00, 04, 56));
            var video3 = new YTVideo("OMSV3", "lesson 3", new TimeSpan(00, 05, 11));
            var video4 = new YTVideo("OMSV4", "lesson 4", new TimeSpan(00, 04, 53));
            var video5 = new YTVideo("OMSV5", "lesson 5", new TimeSpan(00, 02, 35));
            var video6 = new YTVideo("OMSV6", "lesson 6", new TimeSpan(00, 06, 43));

            LinkedList<YTVideo> yTVideos1 = new LinkedList<YTVideo>( new YTVideo[] {
                video1,
                video2,
                video3,
                video4,
                video5,
                video6
            });

            LinkedList<YTVideo> yTVideos = new LinkedList<YTVideo>();
            yTVideos.AddLast(video1);
            yTVideos.AddLast(video2);
            yTVideos.AddLast(video3);
            yTVideos.AddLast(video4);
            yTVideos.AddLast(video5);
            yTVideos.AddLast(video6);

            var node = new LinkedListNode<YTVideo>(video5);
            yTVideos1.AddAfter(yTVideos1.Last.Previous, node);

            yTVideos1.AddBefore(yTVideos1.First.Next, video5);


            foreach (var item in yTVideos1)
            {
                Console.WriteLine(item); 
            }

        }
    }
}
