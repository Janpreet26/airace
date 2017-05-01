﻿using UnityEngine;
using System;

public class MainMenu : MonoBehaviour {

  public static Track[] tracks = new Track[] {

    new Track (new Node (0.0, 15.0, -90.0, 15.0), new Node (2.6047226650039548, 14.772116295183121, -100.0, 15.0), new Node (5.130302149885031, 14.095389311788626, -110.0, 15.0), new Node (7.499999999999999, 12.99038105676658, -120.0, 15.0), new Node (9.641814145298088, 11.490666646784671, -130.0, 15.0), new Node (11.490666646784668, 9.641814145298094, -140.0, 15.0), new Node (12.990381056766577, 7.500000000000005, -150.0, 15.0), new Node (14.095389311788622, 5.130302149885038, -159.99999999999997, 15.0), new Node (14.77211629518312, 2.6047226650039663, -169.99999999999994, 15.0), new Node (15.0, 1.4241161394862392e-14, -179.99999999999994, 15.0), new Node (14.772116295183123, -2.6047226650039383, -189.99999999999994, 15.0), new Node (14.095389311788633, -5.130302149885011, -199.99999999999994, 15.0), new Node (12.990381056766592, -7.49999999999998, -209.99999999999991, 15.0), new Node (11.490666646784689, -9.641814145298069, -219.9999999999999, 15.0), new Node (9.641814145298111, -11.490666646784652, -229.99999999999991, 15.0), new Node (7.500000000000028, -12.990381056766564, -239.9999999999999, 15.0), new Node (5.130302149885064, -14.095389311788614, -249.99999999999986, 15.0), new Node (2.6047226650039934, -14.772116295183114, -259.9999999999999, 15.0), new Node (4.180499908522666e-14, -15.0, -269.99999999999983, 15.0), new Node (-2.6047226650039113, -14.772116295183128, -279.9999999999999, 15.0), new Node (-5.130302149884986, -14.095389311788642, -289.9999999999998, 15.0), new Node (-7.499999999999956, -12.990381056766605, -299.9999999999998, 15.0), new Node (-9.64181414529805, -11.490666646784705, -309.99999999999983, 15.0), new Node (-11.490666646784634, -9.641814145298135, -319.9999999999998, 15.0), new Node (-12.990381056766548, -7.500000000000053, -329.9999999999998, 15.0), new Node (-14.095389311788605, -5.13030214988509, -339.9999999999998, 15.0), new Node (-14.772116295183109, -2.604722665004021, -349.9999999999998, 15.0), new Node (-15.0, -6.936883677559093e-14, -359.9999999999998, 15.0), new Node (-14.772116295183134, 2.6047226650038837, -369.9999999999997, 15.0), new Node (-14.09538931178865, 5.13030214988496, -379.9999999999997, 15.0), new Node (-12.99038105676662, 7.499999999999932, -389.9999999999997, 15.0), new Node (-11.490666646784723, 9.641814145298028, -399.9999999999997, 15.0), new Node (-9.641814145298156, 11.490666646784616, -409.9999999999997, 15.0), new Node (-7.500000000000075, 12.990381056766536, -419.99999999999966, 15.0), new Node (-5.130302149885115, 14.095389311788594, -429.99999999999966, 15.0), new Node (-2.604722665004048, 14.772116295183105, -439.99999999999966, 15.0), new Node (-9.69326744659552e-14, 15.0, -449.99999999999966, 15.0)), 


    new Track (new Node (0, 0, 0, 10), new Node (0, 30, 0, 10), new Node (10, 40, -90, 10), new Node (40, 40, -90, 10), new Node (50, 30, -180, 10), new Node (50, 0, -180, 10), new Node (40, -20, 90, 20), new Node (10, -20, 90, 20)),


    new Track (new Node (0, 0, 0, 12), new Node (0, 100, 0, 12), new Node (50, 300, 270, 17), new Node (100, -100, 180, 27), new Node (50, -200, 90, 20)),
    new Track (new Node (0, 0, 90, 25), new Node (0, 90, 315, 23), new Node (200, 300, 230, 32)),
    new Track (new Node (0, 0, 45, 14.142), new Node (0, 120, 315, 14.142), new Node (20, 140, 315, 14.142), new Node (140, 140, 225, 14.142), new Node (160, 120, 225, 14.142), new Node (160, 0, 135, 14.142), new Node (140, -20, 135, 14.142), new Node (20, -20, 45, 14.142)),
    new Track (new Node (0, 0, 0, 9), new Node (5, 50, 315, 8), new Node (15, 57, 305, 9), new Node (25, 60, 295, 10), new Node (80, 60, 205, 10), new Node (90, 57, 215, 9), new Node (100, 50, 225, 8), new Node (105, 30, 200, 9), new Node (130, -20, 180, 10), new Node (120, -35, 120, 9), new Node (55, -35, 110, 9), new Node (35, -45, 90, 8), new Node (15, -35, 45, 9)),
    new Track (new Node (0, 0, 0, 9), new Node (0, 500, 0, 9), new Node (5, 510, 315, 10), new Node (15, 515, 270, 11), new Node (25, 510, 225, 9), new Node (30, 500, 180, 9), new Node (30, 300, 180, 9), new Node (40, 290, 225, 8), new Node (50, 280, 270, 9), new Node (60, 270, 225, 8), new Node (70, 260, 180, 9), new Node (70, 180, 180, 9), new Node (60, 170, 135, 8), new Node (50, 160, 90, 9), new Node (40, 150, 135, 8), new Node (30, 140, 180, 9), new Node (30, 0, 180, 9), new Node (25, -10, 135, 10), new Node (15, -15, 90, 11), new Node (5, -10, 45, 10)),
    new Track (new Node (0, 0, 0, 9), new Node (0, 50, 0, 9), new Node (5, 60, 315, 8), new Node (10, 65, 270, 9), new Node (60, 65, 270, 9), new Node (65, 70, 315, 9), new Node (70, 75, 0, 11), new Node (65, 80, 45, 9), new Node (60, 85, 90, 8), new Node (-40, 85, 90, 9), new Node (-45, 90, 45, 9), new Node (-50, 100, 0, 11), new Node (-45, 110, 315, 10), new Node (-35, 120, 270, 9), new Node (150, 120, 270, 9), new Node (155, 115, 225, 9), new Node (165, 110, 180, 9), new Node (165, 40, 180, 9), new Node (160, 35, 135, 9), new Node (140, 30, 90, 9), new Node (60, 30, 90, 9), new Node (50, 25, 135, 8), new Node (40, 15, 180, 9), new Node (40, -75, 180, 9), new Node (35, -80, 135, 10), new Node (20, -90, 90, 9), new Node (-60, -90, 90, 9), new Node (-65, -85, 30, 10), new Node (-70, -80, 0, 9), new Node (-70, 50, 0, 9), new Node (-65, 55, 315, 8), new Node (-60, 60, 270, 10), new Node (-50, 50, 225, 9), new Node (-45, 45, 180, 9), new Node (-45, -40, 180, 9), new Node (-40, -45, 225, 9), new Node (-35, -50, 270, 11), new Node (-30, -45, 315, 9), new Node (-25, -40, 0, 9)),
    new Track (new Node (0, 0, 0, 9), new Node (0, 200, 0, 9), new Node (10, 210, 315, 9), new Node (20, 220, 0, 9), new Node (10, 230, 45, 9), new Node (0, 240, 0, 9), new Node (10, 250, 315, 9), new Node (20, 260, 0, 10), new Node (10, 270, 45, 9), new Node (0, 280, 0, 10), new Node (10, 290, 315, 9), new Node (20, 300, 270, 9), new Node (450, 300, 270, 9), new Node (460, 290, 225, 8), new Node (470, 280, 270, 9), new Node (690, 280, 270, 9), new Node (700, 270, 225, 9), new Node (705, 260, 180, 11), new Node (700, 250, 135, 9), new Node (690, 240, 90, 9), new Node (50, 240, 90, 9), new Node (45, 230, 135, 8), new Node (40, 220, 180, 9), new Node (45, 210, 225, 8), new Node (50, 200, 180, 9), new Node (45, 190, 135, 8), new Node (40, 180, 180, 9), new Node (45, 170, 225, 8), new Node (50, 160, 270, 9), new Node (350, 160, 270, 9), new Node (355, 165, 315, 8), new Node (360, 170, 0, 9), new Node (365, 175, 315, 9), new Node (370, 180, 270, 10), new Node (375, 175, 225, 9), new Node (380, 170, 270, 9), new Node (990, 170, 270, 9), new Node (995, 165, 225, 9), new Node (1000, 160, 180, 10), new Node (1000, 140, 180, 10), new Node (995, 135, 135, 9), new Node (990, 130, 90, 9), new Node (30, 130, 90, 9), new Node (25, 125, 135, 9), new Node (20, 120, 180, 10), new Node (25, 115, 225, 9), new Node (30, 110, 270, 9), new Node (990, 110, 270, 9), new Node (995, 105, 225, 8), new Node (1000, 100, 180, 9), new Node (1000, -150, 180, 9), new Node (995, -155, 135, 9), new Node (990, -160, 90, 9), new Node (500, -160, 90, 9), new Node (495, -165, 135, 9), new Node (490, -170, 180, 10), new Node (495, -175, 225, 9), new Node (500, -180, 180, 10), new Node (495, -185, 135, 9), new Node (490, -190, 90, 9), new Node (60, -190, 90, 9), new Node (55, -185, 45, 9), new Node (50, -180, 0, 10), new Node (45, -175, 45, 9), new Node (40, -170, 90, 10), new Node (35, -165, 45, 9), new Node (30, -160, 0, 10), new Node (25, -155, 45, 9), new Node (20, -150, 90, 10), new Node (15, -145, 45, 9), new Node (10, -140, 0, 10), new Node (5, -135, 45, 9), new Node (0, -130, 0, 9))
  };

  public static string olscript = @"
        function Update()
          car:accelerate()
          local pos = car:getPosition()
          local nod = car:getNextNode().position
          local angle = car:getAngleBetweenPoints(pos.x, pos.z, nod.x, nod.z)
          if angle > 0 then
            car:turnLeft()
          else
            car:turnRight()
          end
        end";
  public static string scripht = @"
  local x = 0
  function Update()
    if x < 7 then
      car:accelerate()
      x = x + 1
    end
    if car:getDistanceToLeftSide() < 14 then
      car:turnRight()
    end
    if car:getDistanceToRightSide() < 14 then
      car:turnLeft()
    end
  end";
  public static string script = @"
  function Update()
    if car:getSpeed() < 12 then
      car:accelerate()
    end
    local dl = car:getDistanceToLeftSide()
    local dr = car:getDistanceToRightSide()
    if dl < dr then
      car:turnRight()
    else
      car:turnLeft()
    end
  end";
  public static string secondscript;
  public static bool isTrial = true;
  public static int noRacers = 1;
  public static int trackNumber = 1;
  public static int trackType = 1;

  // Use this for initialization
  void Start() {
		
  }
	
  // Update is called once per frame
  void Update() {
		
  }
}
