// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiSubtitleedit : ComponentBase
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
		builder.AddAttribute(15, "d", "M3.858.02C1.744.23.16 1.91.02 4.09c-.038.598-.02 15.896.02 16.156.3 1.996 1.752 3.455 3.7 3.719.418.057 16.38.04 16.674-.018 1.433-.28 2.614-1.164 3.156-2.363.2-.443.304-.776.377-1.208.047-.282.075-16.036.029-16.509A4.266 4.266 0 0 0 20.348.048C20.065.008 4.261-.02 3.858.02m7.237 6.15c.707.707 1.285 1.299 1.285 1.315 0 .024-.57.03-2.79.03-3.106 0-2.95-.008-3.286.16-1.145.58-1.175 2.2-.052 2.8.34.18.265.174 1.725.192 1.404.018 1.475.023 1.976.153 1.495.388 2.688 1.64 3.015 3.164a4.2 4.2 0 0 1-3.547 5.057c-.347.046-6.605.05-6.605.004 0-.016.573-.602 1.273-1.302L5.36 16.47l1.87-.01c2.07-.009 1.97-.002 2.326-.172a1.566 1.566 0 0 0 .421-2.532c-.431-.43-.571-.461-2.05-.462-1.802 0-2.364-.125-3.253-.721-3.078-2.066-2.152-6.837 1.475-7.597.38-.08.522-.086 2.11-.089l1.551-.003 1.284 1.285m10.067-1.256c0 .017-.578.608-1.284 1.315l-1.284 1.286h-4.427l-1.296-1.298a68.614 68.608 0 0 1-1.296-1.315c0-.01 2.157-.018 4.793-.018 3.813 0 4.794.006 4.794.03m-2.562 7.06-.006 1.308h-4.449l-.033-.094c-.336-.942-.695-1.527-1.346-2.194a4.325 4.325 0 0 1-.292-.313c0-.01 1.38-.016 3.066-.016h3.066l-.006 1.309m1.278 5.78a67.498 67.492 0 0 1 1.284 1.302c0 .01-1.955.018-4.344.018-2.389 0-4.344-.008-4.344-.018 0-.01.103-.12.228-.243a5.453 5.453 0 0 0 1.38-2.185l.053-.16h4.458l1.285 1.285");
		builder.CloseElement();
		builder.CloseElement();
    }
}
