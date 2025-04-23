// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcSalesPerformance : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 48 48";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "fill", "#FFA000");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M38,13c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C44,12.1,41.3,13,38,13 z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M38,10c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C44,9.1,41.3,10,38,10z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M38,16c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C44,15.1,41.3,16,38,16 z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M38,19c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C44,18.1,41.3,19,38,19 z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M38,22c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C44,21.1,41.3,22,38,22 z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M38,25c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C44,24.1,41.3,25,38,25 z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M38,28c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C44,27.1,41.3,28,38,28 z");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M38,31c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C44,30.1,41.3,31,38,31 z");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M38,34c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C44,33.1,41.3,34,38,34 z");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M38,37c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C44,36.1,41.3,37,38,37 z");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M38,40c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C44,39.1,41.3,40,38,40 z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(37, "g");
		builder.AddAttribute(38, "fill", "#FFC107");
		builder.OpenElement(39, "ellipse");
		builder.AddAttribute(40, "cx", "38");
		builder.AddAttribute(41, "cy", "8");
		builder.AddAttribute(42, "rx", "6");
		builder.AddAttribute(43, "ry", "2");
		builder.CloseElement();
		builder.OpenElement(44, "path");
		builder.AddAttribute(45, "d", "M38,12c-2.8,0-5.1-0.6-5.8-1.5C32.1,10.7,32,10.8,32,11c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C43.1,11.4,40.8,12,38,12z");
		builder.CloseElement();
		builder.OpenElement(46, "path");
		builder.AddAttribute(47, "d", "M38,15c-2.8,0-5.1-0.6-5.8-1.5C32.1,13.7,32,13.8,32,14c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C43.1,14.4,40.8,15,38,15z");
		builder.CloseElement();
		builder.OpenElement(48, "path");
		builder.AddAttribute(49, "d", "M38,18c-2.8,0-5.1-0.6-5.8-1.5C32.1,16.7,32,16.8,32,17c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C43.1,17.4,40.8,18,38,18z");
		builder.CloseElement();
		builder.OpenElement(50, "path");
		builder.AddAttribute(51, "d", "M38,21c-2.8,0-5.1-0.6-5.8-1.5C32.1,19.7,32,19.8,32,20c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C43.1,20.4,40.8,21,38,21z");
		builder.CloseElement();
		builder.OpenElement(52, "path");
		builder.AddAttribute(53, "d", "M38,24c-2.8,0-5.1-0.6-5.8-1.5C32.1,22.7,32,22.8,32,23c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C43.1,23.4,40.8,24,38,24z");
		builder.CloseElement();
		builder.OpenElement(54, "path");
		builder.AddAttribute(55, "d", "M38,27c-2.8,0-5.1-0.6-5.8-1.5C32.1,25.7,32,25.8,32,26c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C43.1,26.4,40.8,27,38,27z");
		builder.CloseElement();
		builder.OpenElement(56, "path");
		builder.AddAttribute(57, "d", "M38,30c-2.8,0-5.1-0.6-5.8-1.5C32.1,28.7,32,28.8,32,29c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C43.1,29.4,40.8,30,38,30z");
		builder.CloseElement();
		builder.OpenElement(58, "path");
		builder.AddAttribute(59, "d", "M38,33c-2.8,0-5.1-0.6-5.8-1.5C32.1,31.7,32,31.8,32,32c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C43.1,32.4,40.8,33,38,33z");
		builder.CloseElement();
		builder.OpenElement(60, "path");
		builder.AddAttribute(61, "d", "M38,36c-2.8,0-5.1-0.6-5.8-1.5C32.1,34.7,32,34.8,32,35c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C43.1,35.4,40.8,36,38,36z");
		builder.CloseElement();
		builder.OpenElement(62, "path");
		builder.AddAttribute(63, "d", "M38,39c-2.8,0-5.1-0.6-5.8-1.5C32.1,37.7,32,37.8,32,38c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C43.1,38.4,40.8,39,38,39z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(64, "g");
		builder.AddAttribute(65, "fill", "#FFA000");
		builder.OpenElement(66, "path");
		builder.AddAttribute(67, "d", "M10,19c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C16,18.1,13.3,19,10,19 z");
		builder.CloseElement();
		builder.OpenElement(68, "path");
		builder.AddAttribute(69, "d", "M10,16c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C16,15.1,13.3,16,10,16 z");
		builder.CloseElement();
		builder.OpenElement(70, "path");
		builder.AddAttribute(71, "d", "M10,22c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C16,21.1,13.3,22,10,22 z");
		builder.CloseElement();
		builder.OpenElement(72, "path");
		builder.AddAttribute(73, "d", "M10,25c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C16,24.1,13.3,25,10,25 z");
		builder.CloseElement();
		builder.OpenElement(74, "path");
		builder.AddAttribute(75, "d", "M10,28c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C16,27.1,13.3,28,10,28 z");
		builder.CloseElement();
		builder.OpenElement(76, "path");
		builder.AddAttribute(77, "d", "M10,31c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C16,30.1,13.3,31,10,31 z");
		builder.CloseElement();
		builder.OpenElement(78, "path");
		builder.AddAttribute(79, "d", "M10,34c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C16,33.1,13.3,34,10,34 z");
		builder.CloseElement();
		builder.OpenElement(80, "path");
		builder.AddAttribute(81, "d", "M10,37c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C16,36.1,13.3,37,10,37 z");
		builder.CloseElement();
		builder.OpenElement(82, "path");
		builder.AddAttribute(83, "d", "M10,40c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C16,39.1,13.3,40,10,40 z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(84, "g");
		builder.AddAttribute(85, "fill", "#FFC107");
		builder.OpenElement(86, "ellipse");
		builder.AddAttribute(87, "cx", "10");
		builder.AddAttribute(88, "cy", "14");
		builder.AddAttribute(89, "rx", "6");
		builder.AddAttribute(90, "ry", "2");
		builder.CloseElement();
		builder.OpenElement(91, "path");
		builder.AddAttribute(92, "d", "M10,18c-2.8,0-5.1-0.6-5.8-1.5C4.1,16.7,4,16.8,4,17c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C15.1,17.4,12.8,18,10,18z");
		builder.CloseElement();
		builder.OpenElement(93, "path");
		builder.AddAttribute(94, "d", "M10,21c-2.8,0-5.1-0.6-5.8-1.5C4.1,19.7,4,19.8,4,20c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C15.1,20.4,12.8,21,10,21z");
		builder.CloseElement();
		builder.OpenElement(95, "path");
		builder.AddAttribute(96, "d", "M10,24c-2.8,0-5.1-0.6-5.8-1.5C4.1,22.7,4,22.8,4,23c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C15.1,23.4,12.8,24,10,24z");
		builder.CloseElement();
		builder.OpenElement(97, "path");
		builder.AddAttribute(98, "d", "M10,27c-2.8,0-5.1-0.6-5.8-1.5C4.1,25.7,4,25.8,4,26c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C15.1,26.4,12.8,27,10,27z");
		builder.CloseElement();
		builder.OpenElement(99, "path");
		builder.AddAttribute(100, "d", "M10,30c-2.8,0-5.1-0.6-5.8-1.5C4.1,28.7,4,28.8,4,29c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C15.1,29.4,12.8,30,10,30z");
		builder.CloseElement();
		builder.OpenElement(101, "path");
		builder.AddAttribute(102, "d", "M10,33c-2.8,0-5.1-0.6-5.8-1.5C4.1,31.7,4,31.8,4,32c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C15.1,32.4,12.8,33,10,33z");
		builder.CloseElement();
		builder.OpenElement(103, "path");
		builder.AddAttribute(104, "d", "M10,36c-2.8,0-5.1-0.6-5.8-1.5C4.1,34.7,4,34.8,4,35c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C15.1,35.4,12.8,36,10,36z");
		builder.CloseElement();
		builder.OpenElement(105, "path");
		builder.AddAttribute(106, "d", "M10,39c-2.8,0-5.1-0.6-5.8-1.5C4.1,37.7,4,37.8,4,38c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C15.1,38.4,12.8,39,10,39z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(107, "g");
		builder.AddAttribute(108, "fill", "#FFA000");
		builder.OpenElement(109, "path");
		builder.AddAttribute(110, "d", "M24,28c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C30,27.1,27.3,28,24,28 z");
		builder.CloseElement();
		builder.OpenElement(111, "path");
		builder.AddAttribute(112, "d", "M24,25c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C30,24.1,27.3,25,24,25 z");
		builder.CloseElement();
		builder.OpenElement(113, "path");
		builder.AddAttribute(114, "d", "M24,31c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C30,30.1,27.3,31,24,31 z");
		builder.CloseElement();
		builder.OpenElement(115, "path");
		builder.AddAttribute(116, "d", "M24,34c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C30,33.1,27.3,34,24,34 z");
		builder.CloseElement();
		builder.OpenElement(117, "path");
		builder.AddAttribute(118, "d", "M24,37c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C30,36.1,27.3,37,24,37 z");
		builder.CloseElement();
		builder.OpenElement(119, "path");
		builder.AddAttribute(120, "d", "M24,40c-3.3,0-6-0.9-6-2c0,0.4,0,1.6,0,2c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.4,0-1.6,0-2C30,39.1,27.3,40,24,40 z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(121, "g");
		builder.AddAttribute(122, "fill", "#FFC107");
		builder.OpenElement(123, "ellipse");
		builder.AddAttribute(124, "cx", "24");
		builder.AddAttribute(125, "cy", "23");
		builder.AddAttribute(126, "rx", "6");
		builder.AddAttribute(127, "ry", "2");
		builder.CloseElement();
		builder.OpenElement(128, "path");
		builder.AddAttribute(129, "d", "M24,27c-2.8,0-5.1-0.6-5.8-1.5C18.1,25.7,18,25.8,18,26c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C29.1,26.4,26.8,27,24,27z");
		builder.CloseElement();
		builder.OpenElement(130, "path");
		builder.AddAttribute(131, "d", "M24,30c-2.8,0-5.1-0.6-5.8-1.5C18.1,28.7,18,28.8,18,29c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C29.1,29.4,26.8,30,24,30z");
		builder.CloseElement();
		builder.OpenElement(132, "path");
		builder.AddAttribute(133, "d", "M24,33c-2.8,0-5.1-0.6-5.8-1.5C18.1,31.7,18,31.8,18,32c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C29.1,32.4,26.8,33,24,33z");
		builder.CloseElement();
		builder.OpenElement(134, "path");
		builder.AddAttribute(135, "d", "M24,36c-2.8,0-5.1-0.6-5.8-1.5C18.1,34.7,18,34.8,18,35c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C29.1,35.4,26.8,36,24,36z");
		builder.CloseElement();
		builder.OpenElement(136, "path");
		builder.AddAttribute(137, "d", "M24,39c-2.8,0-5.1-0.6-5.8-1.5C18.1,37.7,18,37.8,18,38c0,1.1,2.7,2,6,2s6-0.9,6-2c0-0.2-0.1-0.3-0.2-0.5 C29.1,38.4,26.8,39,24,39z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
