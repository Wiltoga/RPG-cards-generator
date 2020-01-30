﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace RPGcardsGenerator
{
    [Serializable]
    public class Template
    {
        public Template()
        {
            CustomFonts = new Dictionary<string, byte[]>();
            Widgets = new List<(string, IWidget)>();
        }

        public interface IWidget
        {
            RectangleF Location { get; }
        }

        public Bitmap Background { get; set; }
        public Dictionary<string, byte[]> CustomFonts { get; set; }
        public List<(string, IWidget)> Widgets { get; set; }

        [Serializable]
        public class Counter : Text
        {
            public const int ALT1 = 8;
            public const int ALT2 = 4;
            public const int LEFT = 1;
            public const int RIGHT = 2;
            public const int STACKED = 32;
            public const int VERTICAL = 16;

            public Counter() : base()
            {
                Back = new List<Bitmap>();
                Icons = new List<Bitmap>();
            }

            public List<Bitmap> Back { get; set; }
            public int IconHeight { get; set; }
            public List<Bitmap> Icons { get; set; }
            public int Max { get; set; }
            public int Style { get; set; }
            public int Value { get; set; }
        }

        [Serializable]
        public class Field : IWidget
        {
            public string Content { get; set; }
            public Color DefaultInnerColor { get; set; }
            public string Font { get; set; }
            public RectangleF Location { get; set; }
            public Color OutsideColor { get; set; }
            public float OutsideThickness { get; set; }
            public int Size { get; set; }
        }

        [Serializable]
        public class FieldList : IWidget
        {
            public FieldList()
            {
                Data = new List<(string, int, float)>();
            }

            public List<(string, int, float)> Data { get; set; }
            public RectangleF Location { get; set; }
            public Text Model { get; set; }
        }

        [Serializable]
        public class Gauge : Text
        {
            public const int LEFT = 1;
            public const int MIDDLE = 2;
            public const int RIGHT = 4;
            public const int VERTICAL = 8;
            public Bitmap Back { get; set; }
            public Bitmap Bar { get; set; }
            public float Max { get; set; }
            public int Style { get; set; }
            public float Value { get; set; }
        }

        [Serializable]
        public class Image : IWidget
        {
            public Bitmap Data { get; set; }
            public bool KeepFormat { get; set; }
            public RectangleF Location { get; set; }
        }

        [Serializable]
        public class StatGraph : IWidget
        {
            public StatGraph()
            {
                Statistics = new List<(Header, int)>();
            }

            public string Font { get; set; }
            public Color InnerColor { get; set; }
            public RectangleF Location { get; set; }
            public Color OutsideColor { get; set; }
            public float OutsideThickness { get; set; }
            public int Size { get; set; }
            public List<(Header, int)> Statistics { get; set; }

            [Serializable]
            public class Header
            {
                public Bitmap Image { get; set; }
                public string Text { get; set; }
            }
        }

        [Serializable]
        public class Text : IWidget
        {
            public string Content { get; set; }
            public string Font { get; set; }
            public Color InnerColor { get; set; }
            public RectangleF Location { get; set; }
            public Color OutsideColor { get; set; }
            public float OutsideThickness { get; set; }
            public int Size { get; set; }
        }
    }
}