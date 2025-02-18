﻿using ParkingLotApi.Dtos;
using ParkingLotApi.Models;

namespace ParkingLotApi.Repositories
{
    public interface IParkingLotsRepository
    {
        public Task<ParkingLot> CreateParkingLot(ParkingLot parkingLot);

        public Task<ParkingLot> GetParkingLotById(string id);

        public Task DeleteById(string id);

        public Task<List<ParkingLot>> GetParkingLots(int pageIndex);

        public Task<ParkingLot> UpdateParkingLotById(string id, UpdateRequest request);

        public Task<ParkingLot> GetParkingLotByName(string name);
    }
}
