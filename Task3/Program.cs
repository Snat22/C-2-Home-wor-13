﻿using Task3;

int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
var birdCount = new BirdCount(birdsPerDay);
System.Console.WriteLine("Birds today: "+ birdCount.Today());