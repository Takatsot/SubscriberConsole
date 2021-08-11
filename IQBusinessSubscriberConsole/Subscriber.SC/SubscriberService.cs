using Subscriber.Subscriber.BL;
using Subscriber.Subscriber.SL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Subscriber.Subscriber.SC
{
    public class SubscriberService : ISubscriberContract
    {

        #region Sending Input string to RabbitMQ queue

        /// <summary>
        /// Sends the Input String
        /// </summary>
        /// <param name="Name"></param>

        public void SendInputString(string Name)
            {
                 SubscriberLogic sendName = new SubscriberLogic();
                 sendName.SendInputString(Name);
            }

            #endregion
      
    }
}
