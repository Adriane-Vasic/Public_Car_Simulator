﻿using CarLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Services.Direction
{
    public class ForwardDirectionService : IForwardDirectionService
    {
       

        public Car Reverse(Car car)
        {
            switch (car.Direction)
            {
                case DirectionEnum.North:
                    {
                        car.Direction = DirectionEnum.South;
                        break;
                    }

                case DirectionEnum.West:
                    {
                        car.Direction = DirectionEnum.East;
                        break;
                    }
                case DirectionEnum.South:
                    {
                        car.Direction = DirectionEnum.North;
                        break;
                    }


                case DirectionEnum.East:
                    {
                        car.Direction = DirectionEnum.West;
                        break;
                    }

            }

            car.IsBacking = true;
            return car;
        }

        public Car TurnLeft(Car car)
        {
            switch (car.Direction)
            {
                case DirectionEnum.North:
                    {
                        car.Direction = DirectionEnum.West;
                        break;
                    }

                case DirectionEnum.West:
                    {
                        car.Direction = DirectionEnum.South;
                        break;
                    }
                case DirectionEnum.South:
                    {
                        car.Direction = DirectionEnum.East;
                        break;
                    }


                case DirectionEnum.East:
                    {
                        car.Direction = DirectionEnum.North;
                        break;
                    }

            }
            return car;
        }

        public Car TurnRight(Car car)
        {
            switch (car.Direction)
            {
                case DirectionEnum.North:
                    {
                        car.Direction = DirectionEnum.East;
                        break;
                    }

                case DirectionEnum.East:
                    {
                        car.Direction = DirectionEnum.South;
                        break;
                    }
                case DirectionEnum.South:
                    {
                        car.Direction = DirectionEnum.West;
                        break;
                    }


                case DirectionEnum.West:
                    {
                        car.Direction = DirectionEnum.North;
                        break;
                    }
            }

            return car;
        }
    }
}
