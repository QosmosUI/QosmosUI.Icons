// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons;

public class GrFanOption : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "x", "2");
		builder.AddAttribute(15, "y", "2");
		builder.AddAttribute(16, "width", "20");
		builder.AddAttribute(17, "height", "20");
		builder.AddAttribute(18, "rx", "1");
		builder.AddAttribute(19, "stroke-width", "2");
		builder.CloseElement();
		builder.OpenElement(20, "rect");
		builder.AddAttribute(21, "x", "2");
		builder.AddAttribute(22, "y", "2");
		builder.AddAttribute(23, "width", "20");
		builder.AddAttribute(24, "height", "20");
		builder.AddAttribute(25, "rx", "10");
		builder.AddAttribute(26, "stroke-width", "2");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M14.9999 9.50009C15.4999 9.16675 15.8999 7.80009 15.4999 7.00009C15.0999 6.20009 13.3334 5.66674 13.0001 5.50007M14 10.5001C15.5001 8.5001 14.0001 7.00006 11.5 5.5001C9.95405 4.57263 13.4999 4.00009 16.0001 6.00009C17.8751 7.49994 17 8.50009 14 11.5001V10.5001Z");
		builder.AddAttribute(29, "stroke-width", "2");
		builder.CloseElement();
		builder.OpenElement(30, "path");
		builder.AddAttribute(31, "d", "M8.98522 14.402C8.48522 14.7353 8.08522 16.102 8.48522 16.902C8.88522 17.702 10.6517 18.2354 10.9851 18.402M9.98516 13.402C8.48509 15.402 9.98504 16.902 12.4852 18.402C14.0311 19.3295 10.4852 19.902 7.98502 17.902C6.11005 16.4022 6.98516 15.402 9.98516 12.402V13.402Z");
		builder.AddAttribute(32, "stroke-width", "2");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M9.54159 8.94372C9.20826 8.44372 7.84159 8.04372 7.04159 8.44372C6.24159 8.84372 5.70824 10.6102 5.54157 10.9435M10.5416 9.94366C8.54161 8.44359 7.04156 9.94354 5.54161 12.4437C4.61413 13.9896 4.04159 10.4437 6.04159 7.94352C7.54145 6.06854 8.5416 6.94366 11.5416 9.94366H10.5416Z");
		builder.AddAttribute(35, "stroke-width", "2");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "d", "M14.4436 14.9584C14.7769 15.4584 16.1436 15.8584 16.9436 15.4584C17.7436 15.0584 18.2769 13.2919 18.4436 12.9586M13.4436 13.9584C15.4436 15.4585 16.9436 13.9586 18.4436 11.4584C19.371 9.91249 19.9436 13.4584 17.9436 15.9586C16.4437 17.8336 15.4436 16.9584 12.4436 13.9584H13.4436Z");
		builder.AddAttribute(38, "stroke-width", "2");
		builder.CloseElement();
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "fill-rule", "evenodd");
		builder.AddAttribute(41, "clip-rule", "evenodd");
		builder.AddAttribute(42, "d", "M3.5 5C4.32843 5 5 4.32843 5 3.5C5 2.67157 4.32843 2 3.5 2C2.67157 2 2 2.67157 2 3.5C2 4.32843 2.67157 5 3.5 5Z");
		builder.AddAttribute(43, "stroke-width", "2");
		builder.CloseElement();
		builder.OpenElement(44, "path");
		builder.AddAttribute(45, "fill-rule", "evenodd");
		builder.AddAttribute(46, "clip-rule", "evenodd");
		builder.AddAttribute(47, "d", "M3.5 22C4.32843 22 5 21.3284 5 20.5C5 19.6716 4.32843 19 3.5 19C2.67157 19 2 19.6716 2 20.5C2 21.3284 2.67157 22 3.5 22Z");
		builder.AddAttribute(48, "stroke-width", "2");
		builder.CloseElement();
		builder.OpenElement(49, "path");
		builder.AddAttribute(50, "fill-rule", "evenodd");
		builder.AddAttribute(51, "clip-rule", "evenodd");
		builder.AddAttribute(52, "d", "M20.5 22C21.3284 22 22 21.3284 22 20.5C22 19.6716 21.3284 19 20.5 19C19.6716 19 19 19.6716 19 20.5C19 21.3284 19.6716 22 20.5 22Z");
		builder.AddAttribute(53, "stroke-width", "2");
		builder.CloseElement();
		builder.OpenElement(54, "path");
		builder.AddAttribute(55, "fill-rule", "evenodd");
		builder.AddAttribute(56, "clip-rule", "evenodd");
		builder.AddAttribute(57, "d", "M20.5 5C21.3284 5 22 4.32843 22 3.5C22 2.67157 21.3284 2 20.5 2C19.6716 2 19 2.67157 19 3.5C19 4.32843 19.6716 5 20.5 5Z");
		builder.AddAttribute(58, "stroke-width", "2");
		builder.CloseElement();
		builder.OpenElement(59, "path");
		builder.AddAttribute(60, "fill-rule", "evenodd");
		builder.AddAttribute(61, "clip-rule", "evenodd");
		builder.AddAttribute(62, "d", "M12 14C13.1046 14 14 13.1046 14 12C14 10.8954 13.1046 10 12 10C10.8954 10 10 10.8954 10 12C10 13.1046 10.8954 14 12 14Z");
		builder.AddAttribute(63, "stroke-width", "2");
		builder.CloseElement();
		builder.CloseElement();
    }
}
