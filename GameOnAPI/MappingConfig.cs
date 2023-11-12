using AutoMapper;
using GameOnAPI.DTOs;
using GameOnAPI.Models;

namespace GameOnAPI
{
	public class MappingConfig
	{
		public static MapperConfiguration RegisterMaps()
		{
			var mappingConfig = new MapperConfiguration(config =>
			{
				config.CreateMap<User, PlayerUser>();
				config.CreateMap<PlayerUser, User>();
				config.CreateMap<MatchParticipation, MatchParticipationDTO>();
				config.CreateMap<Match, MatchDTO>();
				config.CreateMap<User, LoginUser>();
			}

			);
			return mappingConfig;	
		}
	}
}
