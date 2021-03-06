﻿using System;
using System.Collections.Generic;
using System.IO;

namespace CDC.Objects.Models
{
    public abstract class SR1Model : SRModel
    {
        #region Normals
        protected static Int32[,] s_aiNormals =
        {
            {0, 0, 4096},
            {-1930, -3344, -1365},
            {3861, 0, -1365},
            {-1930, 3344, -1365},
            {-353, -613, 4034},
            {-697, -1207, 3851},
            {-1019, -1765, 3552},
            {-1311, -2270, 3146},
            {-1563, -2707, 2645},
            {-1768, -3063, 2065},
            {-1920, -3326, 1423},
            {-2014, -3489, 738},
            {-2047, -3547, 30},
            {-2019, -3498, -677},
            {707, 0, 4034},
            {1394, 0, 3851},
            {2039, 0, 3552},
            {2622, 0, 3146},
            {3126, 0, 2645},
            {3536, 0, 2065},
            {3840, 0, 1423},
            {4028, 0, 738},
            {4095, 0, 30},
            {4039, 0, -677},
            {-353, 613, 4034},
            {-697, 1207, 3851},
            {-1019, 1765, 3552},
            {-1311, 2270, 3146},
            {-1563, 2707, 2645},
            {-1768, 3063, 2065},
            {-1920, 3326, 1423},
            {-2014, 3489, 738},
            {-2047, 3547, 30},
            {-2019, 3498, -677},
            {-1311, -3498, -1678},
            {-653, -3547, -1941},
            {24, -3489, -2145},
            {701, -3326, -2285},
            {1358, -3063, -2355},
            {1973, -2707, -2355},
            {2529, -2270, -2285},
            {3009, -1765, -2145},
            {3398, -1207, -1941},
            {3685, -613, -1678},
            {3685, 613, -1678},
            {3398, 1207, -1941},
            {3009, 1765, -2145},
            {2529, 2270, -2285},
            {1973, 2707, -2355},
            {1358, 3063, -2355},
            {701, 3326, -2285},
            {24, 3489, -2145},
            {-653, 3547, -1941},
            {-1311, 3498, -1678},
            {-2373, 2885, -1678},
            {-2745, 2339, -1941},
            {-3033, 1723, -2145},
            {-3231, 1055, -2285},
            {-3331, 355, -2355},
            {-3331, -355, -2355},
            {-3231, -1055, -2285},
            {-3033, -1723, -2145},
            {-2745, -2339, -1941},
            {-2373, -2885, -1678},
            {364, -631, 4030},
            {33, -1270, 3893},
            {1083, -664, 3893},
            {-273, -1899, 3618},
            {787, -1364, 3780},
            {1781, -712, 3618},
            {-544, -2497, 3200},
            {520, -2080, 3489},
            {1541, -1490, 3489},
            {2435, -777, 3200},
            {-767, -3043, 2631},
            {293, -2785, 2989},
            {1331, -2306, 3111},
            {2265, -1646, 2989},
            {3019, -857, 2631},
            {-939, -3504, 1901},
            {110, -3426, 2240},
            {1151, -3100, 2416},
            {2108, -2547, 2416},
            {2912, -1808, 2240},
            {3504, -938, 1901},
            {-1067, -3821, 1017},
            {-52, -3906, 1230},
            {966, -3739, 1364},
            {1922, -3330, 1409},
            {2755, -2706, 1364},
            {3409, -1907, 1230},
            {3843, -985, 1017},
            {-1174, -3923, 42},
            {-238, -4088, 51},
            {711, -4033, 58},
            {1622, -3760, 61},
            {2445, -3285, 61},
            {3137, -2632, 58},
            {3660, -1838, 51},
            {3985, -944, 42},
            {-1265, -3792, -889},
            {-457, -3928, -1064},
            {368, -3900, -1194},
            {1179, -3709, -1275},
            {1941, -3363, -1302},
            {2622, -2876, -1275},
            {3193, -2269, -1194},
            {3631, -1567, -1064},
            {3917, -800, -889},
            {364, 631, 4030},
            {1083, 664, 3893},
            {33, 1270, 3893},
            {1781, 712, 3618},
            {787, 1364, 3780},
            {-273, 1899, 3618},
            {2435, 777, 3200},
            {1541, 1490, 3489},
            {520, 2080, 3489},
            {-544, 2497, 3200},
            {3019, 857, 2631},
            {2265, 1646, 2989},
            {1331, 2306, 3111},
            {293, 2785, 2989},
            {-767, 3043, 2631},
            {3504, 938, 1901},
            {2912, 1808, 2240},
            {2108, 2547, 2416},
            {1151, 3100, 2416},
            {110, 3426, 2240},
            {-939, 3504, 1901},
            {3843, 985, 1017},
            {3409, 1907, 1230},
            {2755, 2706, 1364},
            {1922, 3330, 1409},
            {966, 3739, 1364},
            {-52, 3906, 1230},
            {-1067, 3821, 1017},
            {3985, 944, 42},
            {3660, 1838, 51},
            {3137, 2632, 58},
            {2445, 3285, 61},
            {1622, 3760, 61},
            {711, 4033, 58},
            {-238, 4088, 51},
            {-1174, 3923, 42},
            {3917, 800, -889},
            {3631, 1567, -1064},
            {3193, 2269, -1194},
            {2622, 2876, -1275},
            {1941, 3363, -1302},
            {1179, 3709, -1275},
            {368, 3900, -1194},
            {-457, 3928, -1064},
            {-1265, 3792, -889},
            {-729, 0, 4030},
            {-1117, 606, 3893},
            {-1117, -606, 3893},
            {-1507, 1186, 3618},
            {-1575, 0, 3780},
            {-1507, -1186, 3618},
            {-1890, 1719, 3200},
            {-2061, 589, 3489},
            {-2061, -589, 3489},
            {-1890, -1719, 3200},
            {-2252, 2186, 2631},
            {-2558, 1138, 2989},
            {-2663, 0, 3111},
            {-2558, -1138, 2989},
            {-2252, -2186, 2631},
            {-2565, 2565, 1901},
            {-3022, 1618, 2240},
            {-3260, 552, 2416},
            {-3260, -552, 2416},
            {-3022, -1618, 2240},
            {-2565, -2565, 1901},
            {-2775, 2835, 1017},
            {-3356, 1998, 1230},
            {-3721, 1032, 1364},
            {-3845, 0, 1409},
            {-3721, -1032, 1364},
            {-3356, -1998, 1230},
            {-2775, -2835, 1017},
            {-2810, 2979, 42},
            {-3421, 2250, 51},
            {-3848, 1400, 58},
            {-4067, 475, 61},
            {-4067, -475, 61},
            {-3848, -1400, 58},
            {-3421, -2250, 51},
            {-2810, -2979, 42},
            {-2652, 2992, -889},
            {-3173, 2360, -1064},
            {-3562, 1630, -1194},
            {-3802, 832, -1275},
            {-3883, 0, -1302},
            {-3802, -832, -1275},
            {-3562, -1630, -1194},
            {-3173, -2360, -1064},
            {-2652, -2992, -889},
            {-1778, -3080, -2031},
            {-2174, -2553, -2351},
            {-1124, -3159, -2351},
            {-2482, -1926, -2627},
            {-1519, -2632, -2745},
            {-427, -3112, -2627},
            {-2683, -1207, -2849},
            {-1812, -1959, -3107},
            {-790, -2548, -3107},
            {295, -2927, -2849},
            {-2758, -404, -3000},
            {-1968, -1132, -3408},
            {-1022, -1771, -3548},
            {3, -2270, -3408},
            {1028, -2591, -3000},
            {-2690, 470, -3052},
            {-1953, -147, -3596},
            {-1074, -755, -3879},
            {-117, -1308, -3879},
            {848, -1766, -3596},
            {1753, -2094, -3052},
            {-2472, 1388, -2955},
            {-1751, 963, -3575},
            {-917, 476, -3963},
            {-23, -40, -4095},
            {871, -555, -3963},
            {1710, -1034, -3575},
            {2438, -1447, -2955},
            {-2131, 2266, -2664},
            {-1403, 2070, -3243},
            {-599, 1763, -3647},
            {237, 1361, -3855},
            {1060, 886, -3855},
            {1827, 363, -3647},
            {2495, -179, -3243},
            {3028, -712, -2664},
            {-1729, 2987, -2203},
            {-1013, 2965, -2637},
            {-255, 2819, -2960},
            {513, 2555, -3159},
            {1261, 2184, -3227},
            {1956, 1722, -3159},
            {2569, 1188, -2960},
            {3075, 604, -2637},
            {3452, -4, -2203}
        };
        #endregion

        protected SR1Model(BinaryReader xReader, UInt32 uDataStart, UInt32 uModelData, String strModelName, Platform ePlatform, UInt32 uVersion) :
            base(xReader, uDataStart, uModelData, strModelName, ePlatform, uVersion)
        {
        }

        protected virtual void ReadData(BinaryReader xReader)
        {
            // Get the normals
            _normals = new Vector[s_aiNormals.Length / 3];
            for (int n = 0; n < _normals.Length; n++)
            {
                _normals[n].x = ((float)s_aiNormals[n, 0] / 4096.0f);
                _normals[n].y = ((float)s_aiNormals[n, 1] / 4096.0f);
                _normals[n].z = ((float)s_aiNormals[n, 2] / 4096.0f);
            }

            // Get the vertices
            _vertices = new Vertex[_vertexCount];
            _positionsRaw = new Vector[_vertexCount];
            _positionsPhys = new Vector[_vertexCount];
            _positionsAltPhys = new Vector[_vertexCount];
            _colours = new UInt32[_vertexCount];
            _coloursAlt = new UInt32[_vertexCount];
            ReadVertices(xReader);

            // Get the polygons
            _polygons = new Polygon[_polygonCount];
            _uvs = new UV[_indexCount];
            ReadPolygons(xReader);

            // Generate the output
            GenerateOutput();
        }

        protected virtual void ReadVertex(BinaryReader xReader, int v)
        {
            _vertices[v].positionID = v;

            // Read the local coordinates
            _positionsRaw[v].x = (float)xReader.ReadInt16();
            _positionsRaw[v].y = (float)xReader.ReadInt16();
            _positionsRaw[v].z = (float)xReader.ReadInt16();
        }

        protected virtual void ReadVertices(BinaryReader xReader)
        {
            if (_vertexStart == 0 || _vertexCount == 0)
            {
                return;
            }

            xReader.BaseStream.Position = _vertexStart;

            for (int v = 0; v < _vertexCount; v++)
            {
                ReadVertex(xReader, v);
            }

            return;
        }

        protected abstract void ReadPolygons(BinaryReader xReader);

        protected virtual void ReadMaterial(BinaryReader xReader, int p)
        {
            int v1 = (p * 3) + 0;
            int v2 = (p * 3) + 1;
            int v3 = (p * 3) + 2;

            _polygons[p].v1.UVID = v1;
            _polygons[p].v2.UVID = v2;
            _polygons[p].v3.UVID = v3;

            if (_platform != Platform.Dreamcast)
            {
                Byte v1U = xReader.ReadByte();
                Byte v1V = xReader.ReadByte();

                if (_platform == Platform.PSX)
                {
                    ushort paletteVal = xReader.ReadUInt16();
                    ushort rowVal = (ushort)((ushort)(paletteVal << 2) >> 8);
                    ushort colVal = (ushort)((ushort)(paletteVal << 11) >> 11);
                    _polygons[p].paletteColumn = colVal;
                    _polygons[p].paletteRow = rowVal;
                }
                else
                {
                    _polygons[p].material.textureID = (UInt16)(xReader.ReadUInt16() & 0x07FF);
                }

                Byte v2U = xReader.ReadByte();
                Byte v2V = xReader.ReadByte();

                if (_platform == Platform.PSX)
                {
                    _polygons[p].material.textureID = (UInt16)(((xReader.ReadUInt16() & 0x07FF) - 8) % 8);
                }
                else
                {
                    UInt16 usTemp = xReader.ReadUInt16();
                }

                Byte v3U = xReader.ReadByte();
                Byte v3V = xReader.ReadByte();

                _uvs[v1].u = ((float)v1U) / 255.0f;
                _uvs[v1].v = ((float)v1V) / 255.0f;
                _uvs[v2].u = ((float)v2U) / 255.0f;
                _uvs[v2].v = ((float)v2V) / 255.0f;
                _uvs[v3].u = ((float)v3U) / 255.0f;
                _uvs[v3].v = ((float)v3V) / 255.0f;

                float fCU = (_uvs[v1].u + _uvs[v2].u + _uvs[v3].u) / 3.0f;
                float fCV = (_uvs[v1].v + _uvs[v2].v + _uvs[v3].v) / 3.0f;
                float fSizeAdjust = 1.0f / 255.0f;      // 2.0f seems to work better for dreamcast
                float fOffsetAdjust = 0.5f / 255.0f;

                Utility.AdjustUVs(ref _uvs[v1], fCU, fCV, fSizeAdjust, fOffsetAdjust);
                Utility.AdjustUVs(ref _uvs[v2], fCU, fCV, fSizeAdjust, fOffsetAdjust);
                Utility.AdjustUVs(ref _uvs[v3], fCU, fCV, fSizeAdjust, fOffsetAdjust);
            }
            else
            {
                UInt16 v1U = xReader.ReadUInt16();
                UInt16 v1V = xReader.ReadUInt16();
                UInt16 v2U = xReader.ReadUInt16();
                UInt16 v2V = xReader.ReadUInt16();
                UInt16 v3U = xReader.ReadUInt16();
                UInt16 v3V = xReader.ReadUInt16();

                _uvs[v1].u = Utility.BizarreFloatToNormalFloat(v1U);
                _uvs[v1].v = Utility.BizarreFloatToNormalFloat(v1V);
                _uvs[v2].u = Utility.BizarreFloatToNormalFloat(v2U);
                _uvs[v2].v = Utility.BizarreFloatToNormalFloat(v2V);
                _uvs[v3].u = Utility.BizarreFloatToNormalFloat(v3U);
                _uvs[v3].v = Utility.BizarreFloatToNormalFloat(v3V);

                _polygons[p].material.textureID = (UInt16)((xReader.ReadUInt16() & 0x07FF) - 1);
            }

            _polygons[p].material.colour = 0xFFFFFFFF;

            return;
        }

        protected virtual void GenerateOutput()
        {
            // Make the vertices unique
            _vertices = new Vertex[_indexCount];
            for (UInt32 p = 0; p < _polygonCount; p++)
            {
                _vertices[(3 * p) + 0] = _polygons[p].v1;
                _vertices[(3 * p) + 1] = _polygons[p].v2;
                _vertices[(3 * p) + 2] = _polygons[p].v3;
            }

            // Build the materials array
            _materials = new Material[_materialCount];
            UInt16 mNew = 0;

            foreach (Material xMaterial in _materialsList)
            {
                _materials[mNew] = xMaterial;
                _materials[mNew].ID = mNew;
                mNew++;
            }

            return;
        }
    }
}
