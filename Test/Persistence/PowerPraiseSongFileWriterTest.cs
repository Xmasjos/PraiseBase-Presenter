﻿using Pbp.Persistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Pbp.Model.Song.PowerPraise;
using Pbp.Persistence.Writer;
using Pbp.Model;

namespace Test
{
    
    
    /// <summary>
    ///This is a test class for PowerPraiseSongFileWriterTest and is intended
    ///to contain all PowerPraiseSongFileWriterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PowerPraiseSongFileWriterTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            PowerPraiseSongFileWriter target = new PowerPraiseSongFileWriter();
            string referenceFilename = "powerpraise/Näher, mein Gott zu Dir.ppl";
            string filename = "powerpraise/Näher, mein Gott zu Dir - neu.ppl";

            PowerPraiseSong sng = new PowerPraiseSong();
            sng.Title = "Näher, mein Gott, zu Dir";
            sng.Language = "Deutsch";
            sng.Category = "Anbetung";

            sng.CopyrightTextPosition = PowerPraiseSong.AnnotationTextPosition.LastSlide;
            sng.CopyrightText.Add("Text und Musik: Lowell Mason, 1792-1872");
            sng.SourceTextEnabled = true;
            sng.SourceText = "grünes Buch 339";
            
            sng.BackgroundImages.Add("Blumen\\Blume 3.jpg");

            sng.MainTextFormatting = new PowerPraiseSong.TextFormatting
            {
                Font = new System.Drawing.Font("Times New Roman", 44, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic),
                Color = System.Drawing.Color.White,
                OutlineWidth = 30,
                ShadowDistance = 15
            };
            sng.TranslationTextFormatting = new PowerPraiseSong.TextFormatting
            {
                Font = new System.Drawing.Font("Times New Roman", 20, System.Drawing.FontStyle.Regular),
                Color = System.Drawing.Color.White,
                OutlineWidth = 30,
                ShadowDistance = 20
            };
            sng.CopyrightTextFormatting = new PowerPraiseSong.TextFormatting
            {
                Font = new System.Drawing.Font("Times New Roman", 14, System.Drawing.FontStyle.Regular),
                Color = System.Drawing.Color.White,
                OutlineWidth = 30,
                ShadowDistance = 20
            };
            sng.SourceTextFormatting = new PowerPraiseSong.TextFormatting
            {
                Font = new System.Drawing.Font("Times New Roman", 30, System.Drawing.FontStyle.Regular),
                Color = System.Drawing.Color.White,
                OutlineWidth = 30,
                ShadowDistance = 20
            };
            sng.TextOutlineFormatting = new PowerPraiseSong.TextOutline
            {
                Enabled = false,
                Color = System.Drawing.Color.Black,
            };
            sng.TextShadowFormatting = new PowerPraiseSong.TextShadow 
            {
                Enabled = true,
                Color = System.Drawing.Color.Black,
                Direction = 125                
            };

            sng.TextOrientation = new TextOrientation(VerticalOrientation.Middle, HorizontalOrientation.Left);
            sng.TranslationPosition = PowerPraiseSong.TextDisplayMode.Inline;

            sng.SongTextBorders = new PowerPraiseSong.TextBorders 
            {
                TextLeft = 50,
                TextTop = 40,
                TextRight = 60,
                TextBottom = 70,
                CopyrightBottom = 30,
                SourceTop = 20,
                SourceRight = 40
            };

            var part = new PowerPraiseSongTextPart();
            part.Caption = "Teil 1";
            var slide = new PowerPraiseSongTextSlide();
            slide.Lines.Add("Näher, mein Gott, zu Dir,");
            slide.Lines.Add("sei meine Bitt'!");
            slide.Lines.Add("Näher, o Herr, zu Dir");
            slide.Lines.Add("mit jedem Schritt.");
            slide.BackgroundNr = 1;
            slide.MainSize = 42;
            part.Slides.Add(slide);
            slide = new PowerPraiseSongTextSlide();
            slide.Lines.Add("Nur an dem Herzen Dein");
            slide.Lines.Add("kann ich geborgen sein;");
            slide.Lines.Add("deshalb die Bitte mein:");
            slide.Lines.Add("Näher zu Dir!");
            slide.BackgroundNr = 1;
            part.Slides.Add(slide);
            sng.SongTextParts.Add(part);

            part = new PowerPraiseSongTextPart();
            part.Caption = "Teil 2";
            slide = new PowerPraiseSongTextSlide();
            slide.Lines.Add("Näher, mein Gott, zu Dir!");
            slide.Lines.Add("Ein jeder Tag");
            slide.Lines.Add("soll es neu zeigen mir,");
            slide.Lines.Add("was er vermag:");
            slide.BackgroundNr = 1;
            slide.MainSize = 42;
            part.Slides.Add(slide);
            slide = new PowerPraiseSongTextSlide();
            slide.Lines.Add("Wie seiner Gnade Macht,");
            slide.Lines.Add("Erlösung hat gebracht,");
            slide.Lines.Add("in uns're Sündennacht.");
            slide.Lines.Add("Näher zu Dir!");
            slide.BackgroundNr = 1;
            slide.MainSize = 42;
            part.Slides.Add(slide);
            sng.SongTextParts.Add(part);

            part = new PowerPraiseSongTextPart();
            part.Caption = "Teil 3";
            slide = new PowerPraiseSongTextSlide();
            slide = new PowerPraiseSongTextSlide();
            slide.Lines.Add("Näher, mein Gott, zu Dir!");
            slide.Lines.Add("Dich bet' ich an.");
            slide.Lines.Add("Wie vieles hast an mir,");
            slide.Lines.Add("Du doch getan!");
            slide.BackgroundNr = 1;
            slide.MainSize = 42;
            part.Slides.Add(slide);
            slide = new PowerPraiseSongTextSlide();
            slide.Lines.Add("Von Banden frei und los,");
            slide.Lines.Add("ruh' ich in Deinem Schoss.");
            slide.Lines.Add("Ja, Deine Gnad' ist gross!");
            slide.Lines.Add("Näher zu Dir!");
            slide.BackgroundNr = 1;
            slide.MainSize = 42;
            part.Slides.Add(slide);
            sng.SongTextParts.Add(part);

            sng.SongTextOrder.Add(sng.SongTextParts[0]);
            sng.SongTextOrder.Add(sng.SongTextParts[1]);
            sng.SongTextOrder.Add(sng.SongTextParts[2]);

            target.Save(filename, sng);

            try {
                Pbp.Util.FileUtils.FileEquals(filename, referenceFilename, true);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        /// <summary>
        ///A test for FileTypeDescription
        ///</summary>
        [TestMethod()]
        public void FileTypeDescriptionTest()
        {
            PowerPraiseSongFileWriter target = new PowerPraiseSongFileWriter();
            string actual;
            actual = target.FileTypeDescription;
            Assert.AreEqual(actual, "PowerPraise Lied");
        }

        /// <summary>
        ///A test for FileExtension
        ///</summary>
        [TestMethod()]
        public void FileExtensionTest()
        {
            PowerPraiseSongFileWriter target = new PowerPraiseSongFileWriter();
            string actual;
            actual = target.FileExtension;
            Assert.AreEqual(actual, ".ppl");
        }
    }
}
