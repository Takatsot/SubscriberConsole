using System;
using System.Collections.Generic;
using System.Text;

namespace Subscriber.Subscriber.BL
{
   public interface ISubscriberContract
    {

        #region Sending Input string to RabbitMQ queue
        /// <summary>
        /// Sends the Input String 
        /// </summary>
        /// <param name="Name"></param>
        void SendInputString(string Name);
       
        #endregion

    }
}
