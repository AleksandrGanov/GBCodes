using System;
using System.Reflection;

namespace Ex3151
{
    public delegate void Post(object sender, MessageArgs Msg);

    /// <summary>
    /// Реализация сущности "Пользователь"
    /// </summary>
    class VkUser
    {
        /// <summary>
        /// Username пользователя
        /// </summary>
        public String Username { get; set; }
        private VkUser() { }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="NewUsername">Username пользователя</param>
        public VkUser(string NewUsername)
        {
            this.Username = NewUsername;
        }

        //public void PublicMessage(string File, Image Img, int a)

        /// <summary>
        /// Мeтод публикации записи
        /// </summary>
        /// <param name="File">Содержание сообщения</param>
        public void PublicMessage(string Text)
        {
            var msg = new MessageArgs() { Message = Text };
            Console.WriteLine($"{Text} опубликован {Username}\n");
            eventPost?.Invoke(this, msg);

            //if (eventPost != null)
            //{
            //    eventPost(this, msg);
            //}
        }

        public void PublicMessage(string File, int Id)
        {
            //var msg = new MessageArgs() { Message = File, Id = Id };
            //Console.WriteLine($"{File} опубликован {Username}");
            //EventPost?.Invoke(this, msg);

            //if (EventPost != null)
            //{
            //     EventPost(this, msg);
            //}
        }

        public void GetMyUsers()
        {
            foreach (var item in eventPost.GetInvocationList())
            {
                //Console.WriteLine(">>>" + item.Target.GetType());
                Console.WriteLine(">>>" + item.Target.GetType());

                if (item.Target is VkUser)
                {
                    Console.WriteLine((item.Target as VkUser).Username);
                }
            }
        }

        


        public event Action<object, MessageArgs> EventPost
        {
            add 
            {
                Console.WriteLine("EventPost add");
                
                eventPost += value;
            }
            remove 
            {
                Console.WriteLine("EventPost remove");
                
                eventPost -= value;
            }
        }

        private Action<object, MessageArgs> eventPost;

        /// <summary>
        /// Мутод отображения всех записей на кого подписан текущий пользователь
        /// </summary>
        /// <param name="Msg">Содержание сообщения конкретного поста</param>
        public void Wall(object sender, MessageArgs Msg)
        {
            var user = sender as VkUser;

            //using (var r = new System.IO.StreamWriter($"{this.Username}_wall.txt", true))
            //{
            //    r.WriteLine($"Стена {this.Username} >>> {user.Username} опубликовал: {Msg.Message}");
            //}
            Console.WriteLine($"Стена {this.Username} >>> {user.Username} опубликовал: {Msg.Message}");
        }
    }
}
