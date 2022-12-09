using System.Collections.Specialized;

namespace TruthTable.MEP
{
    partial class MEPClass
    {
        private ListDictionary BoneMake()
        {
            ListDictionary boneNames = new ListDictionary();
            boneNames.Add("center_c_n", "Whole body");
            boneNames.Add("Dmune_c_n", "Chest");
            boneNames.Add("kubi_c_n", "Neck");
            boneNames.Add("ude1_r_n", "Right Shoulder");
            boneNames.Add("ude1_l_n", "Left Shoulder");
            boneNames.Add("ude2_r_n", "Right Elbow");
            boneNames.Add("ude2_l_n", "Left Elbow");
            boneNames.Add("ude3_r_n", "Right Hand");
            boneNames.Add("ude3_l_n", "Left Hand");
            boneNames.Add("asi1_r_n", "Right Thigh");
            boneNames.Add("asi1_l_n", "Left Thigh");
            boneNames.Add("asi2_r_n", "Right Knee");
            boneNames.Add("asi2_l_n", "Left Knee");
            boneNames.Add("asi3_r_n", "Right Foot");
            boneNames.Add("asi3_l_n", "Left Foot");
            boneNames.Add("asi4_r_n", "Right Toes");
            boneNames.Add("asi4_l_n", "Left Toes");
            return boneNames;
        }

        private ListDictionary BoneID()
        {
            ListDictionary boneNames = new ListDictionary();
            boneNames.Add(0, "Whole body");
            boneNames.Add(17, "Chest");
            boneNames.Add(66, "Neck");
            boneNames.Add(115, "Right Shoulder");
            boneNames.Add(148, "Left Shoulder");
            boneNames.Add(68, "Right Elbow");
            boneNames.Add(94, "Left Elbow");
            boneNames.Add(69, "Right Hand");
            boneNames.Add(95, "Left Hand");
            boneNames.Add(2, "Right Thigh");
            boneNames.Add("null", "Left Thigh");
            boneNames.Add(3, "Right Knee");
            boneNames.Add(9, "Left Knee");
            boneNames.Add(4, "Right Foot");
            boneNames.Add(10, "Left Foot");
            boneNames.Add(5, "Right Toes");
            boneNames.Add(11, "Left Toes");
            return boneNames;
        }

        private ListDictionary FlashID()
        {
            ListDictionary flashNames = new ListDictionary();
            flashNames.Add(0, "Full body");
            flashNames.Add(1, "Torso");
            flashNames.Add(2, "Both Legs");
            flashNames.Add(3, "Both Arms");
            flashNames.Add(4, "Left Arm");
            flashNames.Add(5, "Right Arm");
            flashNames.Add(6, "Left Leg");
            flashNames.Add(7, "Right Leg");
            flashNames.Add(8, "Right Palm 1");
            flashNames.Add(9, "Left Palm 1");
            flashNames.Add(10, "Right Foot");
            flashNames.Add(11, "Left Foot");
            flashNames.Add(12, "Right Palm 2");
            flashNames.Add(13, "Left Palm 2");
            flashNames.Add(14, "Eyes");
            flashNames.Add(15, "Mouth");
            flashNames.Add(16, "Both Feet");
            flashNames.Add(17, "Head");
            flashNames.Add(18, "Right Elbow");
            flashNames.Add(19, "Left Elbow");
            flashNames.Add(20, "Right Knee");
            flashNames.Add(21, "Left Knee");
            flashNames.Add(22, "Right Shoulder");
            flashNames.Add(23, "Left Shoulder");
            return flashNames;
        }
    }
}
