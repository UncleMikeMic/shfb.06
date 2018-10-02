﻿using UnityEngine;
using System.Collections;

using Steamworks;

namespace LapinerTools.Steam.Data
{
	/// <summary>
	/// The WorkshopItem class stores all available data about a Steam Workshop item.
	/// You can get the native Steam data (e.g. PublishedFileId) from the WorkshopItem.SteamNative property.
	/// Most properties are self-explanatory and not documented in more detail.
	/// </summary>
	public class WorkshopItem
	{
		/// <summary>
		/// The WorkshopItem.SteamNativeData class contains Steam native data such as PublishedFileId, ItemState or SteamUGCDetails.
		/// You can use this data to make own calls to the Steamworks.NET API.
		/// </summary>
		public class SteamNativeData
		{
			public PublishedFileId_t m_nPublishedFileId { get; set; }
			public SteamUGCDetails_t m_details { get; set; }
			public EItemState m_itemState { get; set; }

			public SteamNativeData()
			{
			}
			public SteamNativeData(PublishedFileId_t p_nPublishedFileId)
			{
				m_nPublishedFileId = p_nPublishedFileId;
			}
		}

		public string Name { get; set; }
		public string Description { get; set; }
		public string OwnerName { get; set; }
		public string PreviewImageURL { get; set; }

		public uint VotesUp { get; set; }
		public uint VotesDown { get; set; }
		public ulong Subscriptions { get; set; }
		public ulong Favorites { get; set; }
		
		public bool IsSubscribed { get; set; }
		public bool IsFavorited { get; set; }
		public bool IsVotedUp { get; set; }
		public bool IsVotedDown { get; set; }
		public bool IsVoteSkipped { get; set; }
		public bool IsOwned { get; set; }

		public bool IsInstalled { get; set; }
		public bool IsDownloading { get; set; }
		public bool IsUpdateNeeded { get; set; }

		public string InstalledLocalFolder { get; set; }
		public ulong InstalledSizeOnDisk { get; set; }
		public System.DateTime InstalledTimestamp { get; set; }

		/// <summary>
		/// Contains Steam native data such as PublishedFileId, ItemState or SteamUGCDetails.
		/// You can use this data to make own calls to the Steamworks.NET API.
		/// </summary>
		public SteamNativeData SteamNative { get; set; }

		public WorkshopItem()
		{
			SteamNative = new SteamNativeData();
		}
	}
}
