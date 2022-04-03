using System;
using System.Collections.Generic;

namespace Ex315
{
    //private Action<object, MessageArgs> EventPost;
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

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="NewUsername">Username пользователя</param>
        public VkUser(string NewUsername) { this.Username = NewUsername; }

        /// <summary>
        /// Мeтод публикации записи
        /// </summary>
        /// <param name="File">Содержание сообщения</param>
        public void PublicMessage(string Text)
        {
            var msgArgs = new MessageArgs() { Message = Text };
            Console.WriteLine($"{Text} опубликован {Username}\n");

            EventPost?.Invoke(this, msgArgs);

            //if (EventPost != null)
            //{
            //    EventPost(this, msgArgs);
            //}
        }

        /// <summary>
        /// Мeтод публикации записи
        /// </summary>
        /// <param name="File">Содержание сообщения</param>
        public void PublicMessage(string Text, params Content[] Args )
        {
            var msgArgs = new MessageArgs() { Message = Text, Contents = Args };
            Console.WriteLine($"{Text} опубликован {Username}\n");
            EventPost?.Invoke(this, msgArgs);

            //if (EventPost != null)
            //{
            //    EventPost(this, msg);
            //}
        }

        /// <summary>
        /// Перменная типа "Делегат"
        /// </summary>
        #region Action
        //private Post EventPost;
        private Action<object, MessageArgs> EventPost;
        #endregion

        /// <summary>
        /// Организация подписки
        /// </summary>
        public void AddFollower(VkUser user)
        {
          
            //if (MessageBox.Show($"{user.Username} посмел нажать кнопку подписки. Подтвердить?",
            //    "",
            //    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Console.WriteLine($"{user.Username} подписался на {this.Username}");
                if (user != this) EventPost += user.Wall;
            }
        }

        /// <summary>
        /// Организация отписки
        /// </summary>
        public void RemoveFollower(VkUser user)
        {
            //if (MessageBox.Show($"{user.Username} посмел нажать кнопку отписки. Подтвердить?",
            //    "",
            //    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Console.WriteLine($"{user.Username} отписался от {this.Username}");
                if (user != this) EventPost -= user.Wall;
            }
        }

        /// <summary>
        /// Получение списка подписчиков
        /// </summary>
        public void GetMyUsers()
        {
            foreach (var item in EventPost.GetInvocationList())
            {
                Console.WriteLine((item.Target as VkUser).Username);
            }
        }

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