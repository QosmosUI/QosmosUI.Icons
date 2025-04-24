// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcWiFiLogo : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "48px";

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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "fill", "#3F51B5");
		builder.AddAttribute(16, "d", "M46,26.48c0,4.527-3.268,7.52-7.3,7.52H9.299C5.269,34,2,30.634,2,26.48V21.52C2,17.366,5.269,14,9.299,14		H38.7c4.032,0,7.3,3.366,7.3,7.52V26.48z");
		builder.CloseElement();
		builder.OpenElement(17, "ellipse");
		builder.AddAttribute(18, "fill", "#3F51B5");
		builder.AddAttribute(19, "cx", "24");
		builder.AddAttribute(20, "cy", "24");
		builder.AddAttribute(21, "rx", "14.902");
		builder.AddAttribute(22, "ry", "15");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(23, "g");
		builder.OpenElement(24, "polygon");
		builder.AddAttribute(25, "fill", "#FFFFFF");
		builder.AddAttribute(26, "points", "17,19 14.264,19 13.427,24.859 12.388,19.028 9.93,19.028 8.864,24.859 8.054,19.028 5.266,19.028 		7.597,29 10.056,29 11.12,22.854 12.209,29 14.693,29 	");
		builder.CloseElement();
		builder.OpenElement(27, "rect");
		builder.AddAttribute(28, "x", "19");
		builder.AddAttribute(29, "y", "22");
		builder.AddAttribute(30, "fill", "#FFFFFF");
		builder.AddAttribute(31, "width", "2.508");
		builder.AddAttribute(32, "height", "7");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "fill", "#FFFFFF");
		builder.AddAttribute(35, "d", "M21.5,19.747C21.5,20.44,20.94,21,20.25,21S19,20.44,19,19.747c0-0.696,0.56-1.258,1.25-1.258		S21.5,19.051,21.5,19.747z");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "fill", "#FFFFFF");
		builder.AddAttribute(38, "d", "M38.561,16c-4.818,0-7.979,0-7.979,0S25,16.193,25,21.914v4.336c0,0,0.101,2.941-3,5.75h16.785		c0,0,5.215,0,5.215-5.553c0-4.879,0-4.879,0-4.879S43.772,16,38.561,16z M37.339,21.369h-5.651v2.236h5.094v2.344h-5.094V29H29V19		h8.339V21.369z M40.25,18.489c0.689,0,1.25,0.562,1.25,1.258C41.5,20.44,40.939,21,40.25,21S39,20.44,39,19.747		C39,19.051,39.561,18.489,40.25,18.489z M41.508,29H39v-7h2.508V29z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
