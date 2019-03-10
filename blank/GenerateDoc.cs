using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using wp = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using a = DocumentFormat.OpenXml.Drawing;
using pic = DocumentFormat.OpenXml.Drawing.Pictures;

namespace blank
{
    public class GeneratedClass
    {
        private CalcRes _resData;
        private static Bitmap _rBitmap;
        // Creates a WordprocessingDocument.
        public void CreatePackage(string filePath, CalcRes res, Bitmap bmp)
        {
            _resData = res;
            _rBitmap = bmp;
            using (var package = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                CreateParts(package);
            }
        }

        // Adds child parts and generates content of the specified part.
        private void CreateParts(WordprocessingDocument wordDocument)
        {
            var noSeparate = new NumberFormatInfo {NumberGroupSeparator = string.Empty};
            const long lcx = 6*161257L;
            const long lcy = 6*161257L;
            // Add a main document part. 
            var mainPart = wordDocument.AddMainDocumentPart();
            // Create the document structure and add some text.
            mainPart.Document = new Document();
            var imagePart = mainPart.AddNewPart<ImagePart>("image/jpeg", "rIdImagePart1"); //создаем рисунок ЛОГО
            GenerateImagePart(imagePart); //генерируем из файла
            var imagePart2 = mainPart.AddNewPart<ImagePart>("image/jpeg", "rIdImagePart2"); //создаем схему
            GenerateImagePart2(imagePart2);
            //--устанавливаем узкие поля
            var body =
                mainPart.Document.AppendChild(
                    new Body(
                        new SectionProperties(new PageMargin
                        {
                            Top = 400,
                            Bottom = 400,
                            Left = 450,
                            Right = 450,
                            Header = 350,
                            Footer = 350,
                            Gutter = 0
                        })));
            // --- первая таблица, месторождение, бригада, и т.п.
            var mTable =
                new Table(
                    new TableProperties(
                        new TableJustification {Val = TableRowAlignmentValues.Center},
                        new TableLayout {Type = TableLayoutValues.Fixed},
                        new TableBorders( //---сетка таблицы
                            new TopBorder {Val = new EnumValue<BorderValues>(BorderValues.Thick), Color = "CC0000"},
                            new RightBorder
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Thick),
                                Color = "CC0000"
                            },
                            new LeftBorder {Val = new EnumValue<BorderValues>(BorderValues.Thick), Color = "CC0000"},
                            new BottomBorder
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Thick),
                                Color = "CC0000"
                            },
                            new InsideHorizontalBorder
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Thick),
                                Color = "CC0000"
                            },
                            new InsideVerticalBorder
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Thick),
                                Color = "CC0000"
                            }
                            ),
                        new TableLayout {Type = TableLayoutValues.Fixed},
                        new TableGrid(
                            new GridColumn {Width = "1800"}, //---столбцы, 3 шт. ширина
                            new GridColumn {Width = "4800"}, //всего 10800
                            new GridColumn {Width = "4200"}
                            )
                        ), //Properties
                    new TableRow(
                        new TableRowProperties(new TableJustification {Val = TableRowAlignmentValues.Center}),
                        new TableCell(
                            new TableCellProperties(
                                new VerticalMerge {Val = MergedCellValues.Restart}),
                            new Paragraph(
                                new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                                    new SpacingBetweenLines {After = "0"}),
                                new Run(
                                    new Drawing( // эмблема интех
                                        new wp.Inline(
                                            new wp.Extent {Cx = lcx, Cy = lcy},
                                            new wp.EffectExtent
                                            {
                                                LeftEdge = 0L,
                                                TopEdge = 39050L,
                                                RightEdge = 0L,
                                                BottomEdge = 0L
                                            },
                                            new wp.DocProperties
                                            {
                                                Id = (UInt32Value) 1U,
                                                Name = "Intech LogoType",
                                                Description = "LOGO.jpg"
                                            },
                                            new wp.NonVisualGraphicFrameDrawingProperties(
                                                new a.GraphicFrameLocks {NoChangeAspect = true}),
                                            new a.Graphic(
                                                new a.GraphicData(
                                                    new pic.Picture(
                                                        new pic.NonVisualPictureProperties(
                                                            new pic.NonVisualDrawingProperties
                                                            {
                                                                Id = (UInt32Value) 0U,
                                                                Name = "Forest Flowers.jpg"
                                                            },
                                                            new pic.NonVisualPictureDrawingProperties()),
                                                        new pic.BlipFill(
                                                            new a.Blip
                                                            {
                                                                Embed = "rIdImagePart1",
                                                                CompressionState = a.BlipCompressionValues.Print
                                                            },
                                                            new a.Stretch(
                                                                new a.FillRectangle())),
                                                        new pic.ShapeProperties(
                                                            new a.Transform2D(
                                                                new a.Offset {X = 0L, Y = 0L},
                                                                new a.Extents {Cx = lcx, Cy = lcy}),
                                                            new a.PresetGeometry(
                                                                new a.AdjustValueList()
                                                                ) {Preset = a.ShapeTypeValues.Rectangle}))
                                                    )
                                                {Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture"})
                                            )
                                        {
                                            DistanceFromTop = (UInt32Value) 10U,
                                            DistanceFromBottom = (UInt32Value) 10U,
                                            DistanceFromLeft = (UInt32Value) 10U,
                                            DistanceFromRight = (UInt32Value) 10U
                                        })
                                    )
                                ) {RsidParagraphAddition = "00A2180E", RsidRunAdditionDefault = "00EC4DA7"}
                            //Paragraph
                            ), //TableSell
                        new TableCell(
                            new TableCellProperties(
                                new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                                new TableCellMargin(new RightMargin {Width = new StringValue((UInt32Value) 100U)})),
                            new Paragraph(
                                new ParagraphProperties(new Justification {Val = JustificationValues.Right},
                                    new SpacingBetweenLines {After = "0"}),
                                new Run(
                                    new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"}, new Bold(),
                                        new FontSize {Val = "22"}),
                                    new Text("Месторождение"))
                                ) //Paragraph
                            ), //TableCell
                        new TableCell(
                            new TableCellProperties(
                                new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                                new TableCellMargin(new LeftMargin {Width = new StringValue((UInt32Value) 100U)})),
                            new Paragraph(
                                new ParagraphProperties(new Justification {Val = JustificationValues.Left},
                                    new SpacingBetweenLines {After = "0"}),
                                new Run(
                                    new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                        new FontSize {Val = "16"}),
                                    new Text(_resData.OilFieldName)))
                            ) //TableCell
                        ), //TableRow
                    InsertHeaderRow("Куст", _resData.ClusterName),
                    InsertHeaderRow("Скважина", _resData.WellNumber),
                    InsertHeaderRow("Сервисная компания", _resData.ServiceCompany),
                    InsertHeaderRow("Бригада", _resData.Brigade),
                    InsertHeaderRow("Мастер", _resData.Master)
                    ); //Table
            body.Append(mTable);
            var dtl = _resData.DTailLenght;
            //таблица с данными
            var dTable =
                new Table(
                    new TableProperties(
                        new TableJustification {Val = TableRowAlignmentValues.Center},
                        new TableLayout {Type = TableLayoutValues.Fixed},
                        new TableBorders( //---сетка таблицы
                            new TopBorder {Val = new EnumValue<BorderValues>(BorderValues.Thick), Color = "CC0000"},
                            new RightBorder
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Thick),
                                Color = "CC0000"
                            },
                            new LeftBorder {Val = new EnumValue<BorderValues>(BorderValues.Thick), Color = "CC0000"},
                            new BottomBorder
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Thick),
                                Color = "CC0000"
                            },
                            new InsideHorizontalBorder
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Thick),
                                Color = "CC0000"
                            },
                            new InsideVerticalBorder
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Thick),
                                Color = "CC0000"
                            }
                            ),
                        new TableLayout {Type = TableLayoutValues.Fixed},
                        new TableGrid(
                            new GridColumn {Width = "3400"}, //---столбцы, 3 шт. ширина
                            new GridColumn {Width = "1000"},
                            new GridColumn {Width = "1000"},
                            new GridColumn {Width = "3400"},
                            new GridColumn {Width = "1000"},
                            new GridColumn {Width = "1000"}
                            )
                        ), //properties
                    Insert2Cell("Исходные данные", "Расчетные данные"),
                    Insert2Cell("Эксплуатационная колонна", "Расчеты объемов"),
                    Insert6Cell_3("Внешний диаметр", _resData.GColumn.Dout.ToString("#.#", noSeparate), "мм", "Всего НКТ", _resData.RColumnVol().ToString("#.#", noSeparate), "м", "3"),
                    Insert6Cell_3("Толщина стенки", _resData.GColumn.ReturnW().ToString("#.#", noSeparate), "мм", "Затруб в интервале поверхность-насос", _resData.RnktVol().ToString("#.#", noSeparate), "м", "3"),
                    Insert6Cell_3("Длинна по трубе", _resData.DColumnLenght.ToString("#.#", noSeparate), "м", "Колонна в интервале насос-забой", _resData.RUnderPumpVol().ToString("#.#", noSeparate), "м", "3"),
                    Insert6Cell_3("Вертикальная глубина", _resData.DColumnHeight.ToString("#.#", noSeparate), "м", "Объем глушения", _resData.RJamFluidVol().ToString("#.#", noSeparate), "м", "3"),
                    Insert6Cell_3("Длинна адаптора", _resData.DAdaptorLenght.ToString("#.#", noSeparate), "м", "Запас жидкости", _resData.RJamFluidStockVol().ToString("#.#", noSeparate), "м", "3"),
                    Insert1L3S_3("«Хвостовик ЭК»", "Полный объем глушения с запасом", _resData.RJamFluidFullVol().ToString("#.#", noSeparate), "м", "3"),
                    Insert3S1L("Внешний диаметр", _resData.GTail.Dout.ToString("#.#", noSeparate), "мм", "Плотности жидкостей"),
                    Insert6Cell_3("Толщина стенки", _resData.GTail.ReturnW().ToString("#.#", noSeparate), "мм", "Плотность раствора глушения", (_resData.RDensityPutFluid()/1000).ToString("#.#", noSeparate), "г/см", "3"),
                    Insert6Cell_3("Длинна по трубе", dtl.ToString("#.#", noSeparate), "м", "Плотность жидкости долива", (_resData.RJamDensity()/1000).ToString("#.#", noSeparate), "г/см", "3"),//
                    Insert3S1L("Вертикальная глубина", _resData.DTailHeight.ToString("#.#", noSeparate), "м", "Скорость прокачки НКТ"),
                    Insert1S1L3S("Тип оборудования", _resData.SEquipment, "Число ходов насоса", _resData.RNktInnigStep().ToString("N0", noSeparate), "_"),
                    Insert1L3S("Нижняя подвеска НКТ", "Время", _resData.RNktInnerTime().ToString(), "мин"),
                    Insert3S1L("Внешний диаметр", _resData.GLowerHanger.Dout.ToString("#.#", noSeparate), "мм", "Скорость прокачки эксплуатационной колонны"),
                    Insert6Cell("Толщина стенки", _resData.GLowerHanger.ReturnW().ToString("#.#", noSeparate), "мм", "Число ходов насоса", _resData.ROutPipeInningStep().ToString("N0", noSeparate), "_"),
                    Insert6Cell("Длинна по трубе", _resData.DLowerHanger.ToString("#.#", noSeparate), "м", "Время", _resData.ROutPipeInnerTime().ToString("#.#", noSeparate), "мин"),
                    Insert3S1L("Вертикальная глубина", _resData.DLowerHangerHeight.ToString("#.#", noSeparate), "м", "Скорость прокачки промывочной жидкости"),
                    Insert1L3S("Верхняя подвеска НКТ", "Число ходов насоса", (_resData.RNktInnigStep() + _resData.ROutPipeInningStep()).ToString("N0", noSeparate), "_"),
                    Insert6Cell("Внешний диаметр", _resData.GUpperHanger.Dout.ToString("#.#", noSeparate), "мм", "Время", (_resData.RNktInnerTime() + _resData.ROutPipeInnerTime()).ToString("#.#", noSeparate), "мин"),
                    Insert3S1L("Толщина стенки", _resData.GUpperHanger.ReturnW().ToString("#.#", noSeparate), "мм", "Другие параметры"),
                    Insert6Cell("Длинна по трубе", _resData.DUpperHanger.ToString("#.#", noSeparate), "м", "НЦД", ((_resData.DPumpPressure + _resData.DNktPressure) / 101325).ToString("#.#", noSeparate), "Атм"),
                    Insert6Cell("Вертикальная глубина", _resData.DUpPerforationHeight.ToString("#.#", noSeparate), "м", "КЦД", (_resData.RKcd() / 101325).ToString("#.#", noSeparate), "Атм"),
                    Insert1L3S("Давление", "Понижение давления на 100 ходов", (_resData.RReducePerStep()/101325).ToString("#.#", noSeparate), "Атм"),
                    InsertStartBMerge("Пластовое", (_resData.DStratumPressure/101325).ToString("#.#", noSeparate), "Атм", true),
                    InsertStartBMerge("На устье (при испытании пород)", (_resData.DOrifice/101325).ToString("#.#", noSeparate), "Атм", false),
                    Insert2BMerge("Газовый фактор", _resData.SGasFactor),
                    Insert1L1B("Интервал перфорации"),
                    InsertStartBMerge("Верх по трубе", _resData.DUpPerforationLenht.ToString("#.#", noSeparate), "м", false),
                    InsertStartBMerge("Верх по вертикали", _resData.DUpPerforationHeight.ToString("#.#", noSeparate), "м", false),
                    InsertStartBMerge("Низ по трубе", _resData.DBottomPerforationLenght.ToString("#.#", noSeparate), "м", false),
                    InsertStartBMerge("Низ по вертикали", _resData.DBottomPerforationHeight.ToString("#.#", noSeparate), "м", false),
                    Insert1L1B("Забой"),
                    InsertStartBMerge("Текущий", _resData.DCurrentStall.ToString("#.#", noSeparate), "м", false),
                    InsertStartBMerge("Искусственный", _resData.DFactitiousStall.ToString("#.#", noSeparate), "м", false),
                    Insert1L1B("Плотности растворов"),
                    InsertStartBMerge("Пластовый флюид", (_resData.DOnAssayDensity/1000).ToString("#.#", noSeparate), "г/см3", false),
                    InsertStartBMerge("Скважинная жидкость", (_resData.DUsedDensity/1000).ToString("#.#", noSeparate), "г/см3", false),
                    Insert1L1B("Данные насоса"),
                    InsertStartBMerge("Скорость прокачки", _resData.DLevelingSpeed.ToString("#.#", noSeparate), "ход/c", false),
                    InsertStartBMerge("Подача насоса", _resData.DPumpInning.ToString("#.#", noSeparate), "л/ход", false),
                    InsertStartBMerge("Давление", (_resData.DPumpPressure/101325).ToString("#.#", noSeparate), "Атм", false),
                    Insert1L1B("Данные о притоке"),
                    InsertStartBMerge("Давление в НКТ", (_resData.DNktPressure/101325).ToString("#.#", noSeparate), "Атм", false),
                    InsertStartBMerge("Давление в затруб. пр.", (_resData.DAnnulusPressure/101325).ToString("#.#", noSeparate), "Атм", false)
                    ); //table

            _resData.DTailLenght = dtl;
            body.Append(dTable);

            body.Append(new Paragraph(
                                new ParagraphProperties(new Justification { Val = JustificationValues.Center },
                                    new SpacingBetweenLines { After = "0" }),
                                new Run(
                                    new Drawing( // эмблема интех
                                        new wp.Inline(
                                            new wp.Extent { Cx = Convert.ToInt64(7*0.5*lcx), Cy = Convert.ToInt64(5*0.5*lcy) },
                                            new wp.EffectExtent
                                            {
                                                LeftEdge = 0L,
                                                TopEdge = 39050L,
                                                RightEdge = 0L,
                                                BottomEdge = 0L
                                            },
                                            new wp.DocProperties
                                            {
                                                Id = (UInt32Value)1U,
                                                Name = "Intech LogoType",
                                                Description = "LOGO.jpg"
                                            },
                                            new wp.NonVisualGraphicFrameDrawingProperties(
                                                new a.GraphicFrameLocks { NoChangeAspect = true }),
                                            new a.Graphic(
                                                new a.GraphicData(
                                                    new pic.Picture(
                                                        new pic.NonVisualPictureProperties(
                                                            new pic.NonVisualDrawingProperties
                                                            {
                                                                Id = (UInt32Value)0U,
                                                                Name = "Forest Flowers.jpg"
                                                            },
                                                            new pic.NonVisualPictureDrawingProperties()),
                                                        new pic.BlipFill(
                                                            new a.Blip
                                                            {
                                                                Embed = "rIdImagePart2",
                                                                CompressionState = a.BlipCompressionValues.Print
                                                            },
                                                            new a.Stretch(
                                                                new a.FillRectangle())),
                                                        new pic.ShapeProperties(
                                                            new a.Transform2D(
                                                                new a.Offset { X = 0L, Y = 0L },
                                                                new a.Extents { Cx = 70, Cy = 50 }),
                                                            new a.PresetGeometry(
                                                                new a.AdjustValueList()
                                                                ) { Preset = a.ShapeTypeValues.Rectangle }))
                                                    ) { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" })
                                            )
                                        {
                                            DistanceFromTop = (UInt32Value)10U,
                                            DistanceFromBottom = (UInt32Value)10U,
                                            DistanceFromLeft = (UInt32Value)10U,
                                            DistanceFromRight = (UInt32Value)10U
                                        })
                                    )
                                ) { RsidParagraphAddition = "00A2180E", RsidRunAdditionDefault = "00EC4DA7" });
            //дополнительные параметры
            wordDocument.PackageProperties.Creator = "Интех";
            wordDocument.PackageProperties.Title = "План глушения";
            wordDocument.PackageProperties.Subject = "План работ";
            wordDocument.PackageProperties.Keywords = "План Глушение Работы";
            wordDocument.PackageProperties.LastModifiedBy = "Щербаков Дмитрий";
            wordDocument.Close();
        }

        private static void GenerateImagePart(OpenXmlPart part)
        {
            using (Stream imageStream = File.Open(@"LOGO.wmf", FileMode.Open))
            {
                part.FeedData(imageStream);
            }
        }

        private static void GenerateImagePart2(OpenXmlPart part)
        {
            _rBitmap.Save("test.wmf", ImageFormat.Wmf);
            using (Stream imageStream = File.Open("test.wmf", FileMode.Open))
            {
                
                //_rBitmap.Save(imageStream, ImageFormat.Wmf);
                part.FeedData(imageStream);
            }
        }

        private static TableRow InsertHeaderRow(string nParam, string nValue)
        {
            return new TableRow(
                new TableRowProperties(new TableJustification {Val = TableRowAlignmentValues.Center}),
                new TableCell(new TableCellProperties(
                    new Paragraph(new VerticalMerge()))
                    ), //TableCell
                new TableCell(
                    new TableCellProperties(
                        new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                        new TableCellMargin(new RightMargin {Width = new StringValue((UInt32Value) 100U)})),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Right},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "22"}, new Bold()),
                            new Text(nParam)))
                    ), //TableCell
                new TableCell(
                    new TableCellProperties(
                        new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                        new TableCellMargin(new LeftMargin {Width = new StringValue((UInt32Value) 100U)})),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Left},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}),
                            new Text(nValue)))
                    ) //TableCell
                ); //TableRow
        }

        private static TableRow Insert1L1B(string lParam)
        {
            return new TableRow(
                new TableCell(
                    new TableCellProperties(
                        new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                        new HorizontalMerge {Val = MergedCellValues.Restart}),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}, new Bold()),
                            new Text(lParam)))
                    ), //TableCell,
                AddContinueCell(),
                AddContinueCell(),
                new TableCell(
                    new TableCellProperties( //не трогаем с гридспан
                        new GridSpan {Val = 3},
                        new VerticalMerge {Val = MergedCellValues.Continue}),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                            new SpacingBetweenLines {After = "0"})
                        )
                    )
                );
        }

        private static TableRow Insert2BMerge(string lParam, string lCount)
        {
            return new TableRow(
                new TableCell(
                    new TableCellProperties(new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                        new TableCellMargin(new LeftMargin {Width = new StringValue((UInt32Value) 100U)})),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Left},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}),
                            new Text(lParam)))
                    ), //TableCell
                new TableCell( //не трогаем
                    new TableCellProperties(new HorizontalMerge {Val = MergedCellValues.Restart}),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}),
                            new Text(lCount))
                        )
                    ), //tableCell
                new TableCell(
                    new TableCellProperties(new HorizontalMerge {Val = MergedCellValues.Continue}),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                            new SpacingBetweenLines {After = "0"})
                        )
                    ), //tableCell
                new TableCell(
                    new TableCellProperties( //не трогаем с гридспан
                        new GridSpan {Val = 3},
                        new VerticalMerge {Val = MergedCellValues.Continue}),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                            new SpacingBetweenLines {After = "0"})
                        )
                    )
                ); //table row
        }

        private static TableRow InsertStartBMerge(string lParam, string lCount, string lDim, bool first)
        {
            var vm = first
                ? new VerticalMerge {Val = MergedCellValues.Restart}
                : new VerticalMerge {Val = MergedCellValues.Continue};

            

            return new TableRow(new TableRowProperties(new TableJustification {Val = TableRowAlignmentValues.Center}),
                new TableCell(
                    new TableCellProperties(
                        new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                        new TableCellMargin(new LeftMargin {Width = new StringValue((UInt32Value) 100U)})),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Left},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}),
                            new Text(lParam)))
                    ), //TableCell
                AddDCountCell(lCount),
                AddDDimCell(lDim),
                new TableCell(
                    new TableCellProperties(
                        // new TableCellWidth{ Width = "1134", Type = TableWidthUnitValues.Dxa },
                        new GridSpan {Val = 3},
                        vm),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}, new Bold()))
                        )
                    ) //TableCell

                ); //table row
        }

        private static TableRow Insert2Cell(string lStr, string rStr)
        {
            return new TableRow(
                new TableRowProperties(new TableJustification {Val = TableRowAlignmentValues.Center}),
                new TableCell(
                    new TableCellProperties(new HorizontalMerge {Val = MergedCellValues.Restart}),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "18"}, new Bold()),
                            new Text(lStr)))
                    ), //tableCell
                AddContinueCell(),
                AddContinueCell(),
                new TableCell(
                    new TableCellProperties(new HorizontalMerge {Val = MergedCellValues.Restart}),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "18"}, new Bold()),
                            new Text(rStr)))
                    ), //tableCell
                AddContinueCell(),
                AddContinueCell()
                ); //tablerow
        }

        private static TableRow Insert6Cell(string lParam, string lCount, string lDim, string rParam, string rCount,
            string rDim)
        {
            return new TableRow(
                new TableCell(
                    new TableCellProperties(
                        new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                        new TableCellMargin(new LeftMargin {Width = new StringValue((UInt32Value) 100U)})),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Left},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}),
                            new Text(lParam)))
                    ), //TableCell
                AddDCountCell(lCount),
                AddDDimCell(lDim),
                new TableCell(
                    new TableCellProperties(
                        new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                        new TableCellMargin(new LeftMargin {Width = new StringValue((UInt32Value) 100U)})),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Left},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}),
                            new Text(rParam)))
                    ), //TableCell
                AddDCountCell(rCount),
                AddDDimCell(rDim)
                ); //table row
        }

        private static TableRow Insert6Cell_3(string lParam, string lCount, string lDim, string rParam, string rCount,
            string rDim, string rDimUp)
        {
            return new TableRow(
                new TableCell(
                    new TableCellProperties(
                        new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                        new TableCellMargin(new LeftMargin {Width = new StringValue((UInt32Value) 100U)})),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Left},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}),
                            new Text(lParam)))
                    ), //TableCell
                AddDCountCell(lCount),
                AddDDimCell(lDim),
                new TableCell(
                    new TableCellProperties(
                        new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                        new TableCellMargin(new LeftMargin {Width = new StringValue((UInt32Value) 100U)})),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Left},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}),
                            new Text(rParam)))
                    ), //TableCell
                AddDCountCell(rCount),
                new TableCell(
                    new TableCellProperties(new TableCellVerticalAlignment
                    {
                        Val = TableVerticalAlignmentValues.Center
                    }),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}),
                            new Text(rDim)),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"},
                                new VerticalTextAlignment {Val = VerticalPositionValues.Superscript}),
                            new Text(rDimUp))
                        )
                    ) //TableCell
                ); //table row
        }

        private static TableRow Insert1L3S_3(string lParam, string rParam, string rCnt, string rDim, string rDimUp)
        {
            return new TableRow(
                new TableCell(
                    new TableCellProperties(
                        new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                        new HorizontalMerge {Val = MergedCellValues.Restart}),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}, new Bold()),
                            new Text(lParam)))
                    ), //TableCell
                AddContinueCell(),
                AddContinueCell(),
                new TableCell(
                    new TableCellProperties(
                        new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                        new TableCellMargin(new LeftMargin {Width = new StringValue((UInt32Value) 100U)})),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Left},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}),
                            new Text(rParam)))
                    ), //TableCell
                AddDCountCell(rCnt),
                new TableCell(
                    new TableCellProperties(new TableCellVerticalAlignment
                    {
                        Val = TableVerticalAlignmentValues.Center
                    }),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}),
                            new Text(rDim)),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"},
                                new VerticalTextAlignment {Val = VerticalPositionValues.Superscript}),
                            new Text(rDimUp))
                        )
                    ) //TableCell
                ); //table row
        }

        private static TableRow Insert3S1L(string lParam, string lCnt, string lDim, string rParam)
        {
            return new TableRow(
                new TableCell(
                    new TableCellProperties(
                        new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                        new TableCellMargin(new LeftMargin {Width = new StringValue((UInt32Value) 100U)})),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Left},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}),
                            new Text(lParam)))
                    ), //TableCell
                AddDCountCell(lCnt),
                AddDDimCell(lDim),
                new TableCell(
                    new TableCellProperties(
                        new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                        new HorizontalMerge {Val = MergedCellValues.Restart}),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}, new Bold()),
                            new Text(rParam)))
                    ), //TableCell
                AddContinueCell(),
                AddContinueCell()
                ); //table row
        }

        private static TableRow Insert1S1L3S(string lParam, string lData, string rParam, string rCnt, string rDim)
        {
            return new TableRow(
                new TableCell(
                    new TableCellProperties(new TableCellVerticalAlignment
                    {
                        Val = TableVerticalAlignmentValues.Center
                    }),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}, new Bold()),
                            new Text(lParam)))
                    ), //TableCell
                new TableCell(
                    new TableCellProperties(new HorizontalMerge {Val = MergedCellValues.Restart}),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}),
                            new Text(lData))
                        )
                    ), //tableCell
                AddContinueCell(),
                new TableCell(
                    new TableCellProperties(
                        new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                        new TableCellMargin(new LeftMargin {Width = new StringValue((UInt32Value) 100U)})),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Left},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}),
                            new Text(rParam)))
                    ), //TableCell
                AddDCountCell(rCnt),
                AddDDimCell(rDim)
                ); //table row
        }

        private static TableRow Insert1L3S(string lParam, string rParam, string rCnt, string rDim)
        {
            return new TableRow(
                new TableCell(
                    new TableCellProperties(
                        new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                        new HorizontalMerge {Val = MergedCellValues.Restart}),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}, new Bold()),
                            new Text(lParam)))
                    ), //TableCell
                AddContinueCell(),
                AddContinueCell(),
                new TableCell(
                    new TableCellProperties(
                        new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                        new TableCellMargin(new LeftMargin {Width = new StringValue((UInt32Value) 100U)})),
                    new Paragraph(
                        new ParagraphProperties(new Justification {Val = JustificationValues.Left},
                            new SpacingBetweenLines {After = "0"}),
                        new Run(
                            new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                                new FontSize {Val = "16"}),
                            new Text(rParam)))
                    ), //TableCell
                AddDCountCell(rCnt),
                AddDDimCell(rDim)
                ); //table row
        }

        private static TableCell AddDCountCell(string cnt)
        {
            return new TableCell(
                new TableCellProperties(
                    new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center},
                    new TableCellMargin(new RightMargin {Width = new StringValue((UInt32Value) 100U)})),
                new Paragraph(
                    new ParagraphProperties(new Justification {Val = JustificationValues.Right},
                        new SpacingBetweenLines {After = "0"}),
                    new Run(
                        new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                            new FontSize {Val = "16"}),
                        new Text(cnt)))
                );
        }

        private static TableCell AddDDimCell(string dim)
        {
            return new TableCell(
                new TableCellProperties(new TableCellVerticalAlignment {Val = TableVerticalAlignmentValues.Center}),
                new Paragraph(
                    new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                        new SpacingBetweenLines {After = "0"}),
                    new Run(
                        new RunProperties(new RunFonts {HighAnsi = "Arial Narrow"},
                            new FontSize {Val = "16"}),
                        new Text(dim)))
                );
        }

        private static TableCell AddContinueCell()
        {
            return new TableCell(
                new TableCellProperties(new HorizontalMerge {Val = MergedCellValues.Continue}),
                new Paragraph(
                    new ParagraphProperties(new Justification {Val = JustificationValues.Center},
                        new SpacingBetweenLines {After = "0"})
                    )
                );
        }
    }



}

    
