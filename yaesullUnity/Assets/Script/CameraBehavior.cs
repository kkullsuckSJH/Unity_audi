using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{

    public float sensitivity = 8F;
    
    private float mHdg = 0F, mPitch = 0F;
    private int seat = 0;

    void Update()
    {
        float deltaX = Input.GetAxis("Mouse X") * sensitivity;
        float deltaY = Input.GetAxis("Mouse Y") * sensitivity;

        if (Input.GetMouseButton(0))
        {
            ChangeHeading(deltaX);
            ChangePitch(-deltaY);
        }
        else if (Input.GetMouseButton(1))
        {
            ChangeHeading(deltaX);
            ChangePitch(-deltaY);
        }
        else
        {
            Debug.Log("mouse-error");
            return;
        }
        Debug.Log(transform.localEulerAngles);
    }

    public void ChangePosition(int pos)
    {
        if ((pos > 100 && pos < 116) || (pos > 200 && pos < 223) || (pos > 300 && pos < 325)) seat = pos;

        if (pos == -1) // left button
        {
            if ((seat > 100 && seat < 116) && seat % 5 != 1) seat--;
            if ((seat > 200 && seat < 223) && seat % 7 != 1) seat--;
            if ((seat > 300 && seat < 325) && seat % 8 != 1) seat--;
            Debug.Log(seat);
        }
        if (pos == -2) // right button
        {
            if (seat > 100 && seat < 116)
            {
                if (seat % 5 != 0) seat++;
            }
            if (seat > 200 && seat < 221)
            {
                if (seat % 7 != 0) seat++;
            }
            if (seat == 221 && seat != 222) seat++;
            if (seat > 300 && seat < 325)
            {
                if (seat % 8 != 0) seat++;
            }
            Debug.Log(seat);
        }

        switch (seat)
        {
            case 101:
                transform.localPosition = new Vector3(1179, 38, 828);
                break;
            case 102:
                transform.localPosition = new Vector3(946, 35, 856);
                break;
            case 103:
                transform.localPosition = new Vector3(700, 36, 867);
                break;
            case 104:
                transform.localPosition = new Vector3(436, 36, 858);
                break;
            case 105:
                transform.localPosition = new Vector3(222, 38, 839);
                break;
            case 106:
                transform.localPosition = new Vector3(1208, 76, 1150);
                break;
            case 107:
                transform.localPosition = new Vector3(946, 72, 1170);
                break;
            case 108:
                transform.localPosition = new Vector3(700, 66, 1146);
                break;
            case 109:
                transform.localPosition = new Vector3(436, 77, 1169);
                break;
            case 110:
                transform.localPosition = new Vector3(190, 88, 1171);
                break;
            case 111:
                transform.localPosition = new Vector3(1208, 142, 1489);
                break;
            case 112:
                transform.localPosition = new Vector3(946, 146, 1524);
                break;
            case 113:
                transform.localPosition = new Vector3(700, 123, 1456);
                break;
            case 114:
                transform.localPosition = new Vector3(436, 136, 1518);
                break;
            case 115:
                transform.localPosition = new Vector3(190, 135, 1491);
                break;
            case 201:
                transform.localPosition = new Vector3(1297, 281, 1380);
                break;
            case 202:
                transform.localPosition = new Vector3(1158, 292, 1419);
                break;
            case 203:
                transform.localPosition = new Vector3(933, 292, 1440);
                break;
            case 204:
                transform.localPosition = new Vector3(697, 292, 1451);
                break;
            case 205:
                transform.localPosition = new Vector3(464, 292, 1451);
                break;
            case 206:
                transform.localPosition = new Vector3(230, 292, 1413);
                break;
            case 207:
                transform.localPosition = new Vector3(100, 292, 1404);
                break;
            case 208:
                transform.localPosition = new Vector3(1306, 352, 1615);
                break;
            case 209:
                transform.localPosition = new Vector3(1163, 352, 1624);
                break;
            case 210:
                transform.localPosition = new Vector3(990, 352, 1656);
                break;
            case 211:
                transform.localPosition = new Vector3(699, 352, 1656);
                break;
            case 212:
                transform.localPosition = new Vector3(411, 352, 1656);
                break;
            case 213:
                transform.localPosition = new Vector3(238, 350, 1617);
                break;
            case 214:
                transform.localPosition = new Vector3(193, 346, 1617);
                break;
            case 215:
                transform.localPosition = new Vector3(1342, 476, 1946);
                break;
            case 216:
                transform.localPosition = new Vector3(1169, 476, 1962);
                break;
            case 217:
                transform.localPosition = new Vector3(991, 476, 1962);
                break;
            case 218:
                transform.localPosition = new Vector3(800, 456, 1934);
                break;
            case 219:
                transform.localPosition = new Vector3(597, 456, 1934);
                break;
            case 220:
                transform.localPosition = new Vector3(416, 472, 1972);
                break;
            case 221:
                transform.localPosition = new Vector3(238, 475, 1957);
                break;
            case 222:
                transform.localPosition = new Vector3(55, 481, 1957);
                break;
            case 301:
                transform.localPosition = new Vector3(1322, 700, 1884);
                break;
            case 302:
                transform.localPosition = new Vector3(1150, 695, 1898);
                break;
            case 303:
                transform.localPosition = new Vector3(982, 697, 1916);
                break;
            case 304:
                transform.localPosition = new Vector3(792, 697, 1927);
                break;
            case 305:
                transform.localPosition = new Vector3(595, 696, 1927);
                break;
            case 306:
                transform.localPosition = new Vector3(413, 696, 1919);
                break;
            case 307:
                transform.localPosition = new Vector3(247, 696, 1905);
                break;
            case 308:
                transform.localPosition = new Vector3(57, 696, 1885);
                break;
            case 309:
                transform.localPosition = new Vector3(1344, 858, 2168);
                break;
            case 310:
                transform.localPosition = new Vector3(1154, 856, 2186);
                break;
            case 311:
                transform.localPosition = new Vector3(988, 862, 2215);
                break;
            case 312:
                transform.localPosition = new Vector3(802, 862, 2215);
                 break;
            case 313:
                transform.localPosition = new Vector3(592, 862, 2215);
                break;
            case 314:
                transform.localPosition = new Vector3(403, 835, 2169);
                break;
            case 315:
                transform.localPosition = new Vector3(248, 844, 2169);
                break;
            case 316:
                transform.localPosition = new Vector3(57, 866, 2203);
                break;
            case 317:
                transform.localPosition = new Vector3(1288, 985, 2386);
                break;
            case 318:
                transform.localPosition = new Vector3(1185, 985, 2398);
                break;
            case 319:
                transform.localPosition = new Vector3(1035, 982, 2409);
                break;
            case 320:
                transform.localPosition = new Vector3(804, 983, 2424);
                break;
            case 321:
                transform.localPosition = new Vector3(588, 983, 2424);
                break;
            case 322:
                transform.localPosition = new Vector3(363, 984, 2415);
                break;
            case 323:
                transform.localPosition = new Vector3(246, 985, 2403);
                break;
            case 324:
                transform.localPosition = new Vector3(110, 983, 2385);
                break;
        }
        transform.localEulerAngles = new Vector3(0, 180, 0);
        Debug.Log(transform.localPosition);
        Debug.Log(transform.localEulerAngles);
        Debug.Log(seat);
    }

    public void ChangeHeading(float aVal)
    {
        mHdg += aVal;
        WrapAngle(ref mHdg);
        transform.localEulerAngles = new Vector3(mPitch, mHdg, 0);
    }

    public void ChangePitch(float aVal)
    {
        mPitch += aVal;
        WrapAngle(ref mPitch);
        transform.localEulerAngles = new Vector3(mPitch, mHdg, 0);
    }

    public static void WrapAngle(ref float angle)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
    }

}
