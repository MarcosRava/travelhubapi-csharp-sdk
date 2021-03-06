﻿using System;
using Newtonsoft.Json;

namespace TravelHubApi.Sdk.Hotel.Models
{
    public class Booking
    {
        /// <summary>
        /// Gets or sets the booking id.
        /// </summary>
        [JsonProperty(Order = 0)]
        public virtual string Id { get; set; }

        /// <summary>
        /// Gets or sets the booking code.
        /// </summary>
        [JsonProperty(Order = 1)]
        public virtual string Code { get; set; }

        /// <summary>
        /// Gets or sets the booking group.
        /// </summary>
        [JsonProperty(Order = 2)]
        public virtual string BookingGroup { get; set; }

        /// <summary>
        /// Gets or sets the sales module.
        /// </summary>
        [JsonProperty(Order = 3)]
        public virtual int? SalesModule { get; set; }

        /// <summary>
        /// Gets or sets the expire date.
        /// </summary>
        [JsonProperty(Order = 4)]
        public virtual DateTime ExpireDate { get; set; }

        /// <summary>
        /// Gets or sets the check-in at hotel.
        /// </summary>
        [JsonProperty(Order = 5)]
        public virtual DateTime CheckIn { get; set; }

        /// <summary>
        /// Gets or sets the check-out at hotel.
        /// </summary>
        [JsonProperty(Order = 6)]
        public virtual DateTime CheckOut { get; set; }

        /// <summary>
        /// Gets or sets the check-out at hotel.
        /// </summary>
        [JsonProperty(Order = 7)]
        public virtual DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the booking vendor.
        /// </summary>
        [JsonProperty(Order = 8)]
        public virtual Vendor Vendor { get; set; }

        /// <summary>
        /// Gets or sets the hotel booked.
        /// </summary>
        [JsonProperty(Order = 9)]
        public virtual Hotel Hotel { get; set; }

        /// <summary>
        /// Gets or sets the payments forms.
        /// </summary>
        [JsonProperty(Order = 10)]
        public virtual Payments Payments { get; set; }

        /// <summary>
        /// Gets or sets the booking remarks.
        /// </summary>
        [JsonProperty(Order = 11)]
        public virtual Remarks Remarks { get; set; }
    }
}
