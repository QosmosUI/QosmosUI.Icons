// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiThangs : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M20.18 13.902a1.902 1.902 0 1 1 0-3.804 1.902 1.902 0 0 1 0 3.804m0-5.722A3.82 3.82 0 0 0 16.36 12v3.82h3.82a3.82 3.82 0 1 0 0-7.64m-8.656 5.722A1.907 1.907 0 0 1 9.611 12c0-1.05.857-1.902 1.913-1.902s1.913.852 1.913 1.902c0 1.05-.857 1.902-1.913 1.902m-7.683 0A1.907 1.907 0 0 1 1.928 12c0-1.05.857-1.902 1.913-1.902 1.057 0 1.913.852 1.913 1.902 0 1.05-.856 1.902-1.913 1.902m11.514-2.107-.002-.032a3.76 3.76 0 0 0-.04-.37l-.004-.019a3.693 3.693 0 0 0-.081-.373V11a3.836 3.836 0 0 0-3.704-2.82H3.84a3.833 3.833 0 0 0-3.794 3.254l-.001.008c-.018.118-.03.236-.036.357l-.002.02v.016C.006 11.89 0 11.945 0 12c0 .07.007.137.01.206l.002.032c.008.124.021.248.041.37l.003.018a3.833 3.833 0 0 0 3.786 3.194h11.523V12c0-.07-.006-.137-.01-.205");
		builder.CloseElement();
		builder.CloseElement();
    }
}
