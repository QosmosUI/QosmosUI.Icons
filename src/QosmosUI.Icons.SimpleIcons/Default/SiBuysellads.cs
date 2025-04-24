// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiBuysellads : ComponentBase
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
		builder.AddAttribute(15, "d", "M24 16.4h-2.685l-.716-2.704-3.3 2.704h-2.675l2.796-8.821h3.784zm-5.955-2.785h2.544l-1.272-4.744zM5.581 11.849c.939.151 1.676 1.049 1.676 2.149 0 1.282-.677 2.392-2.403 2.392H0V7.579h4.32c1.736 0 2.573 1.141 2.573 2.251 0 1.09-.474 1.837-1.312 2.019m-3.502 2.634 1.988-.01c.535 0 .868-.313.868-.788 0-.434-.313-.787-.868-.787H2.079zm0-4.986v1.463h1.726c.464 0 .777-.302.777-.736 0-.424-.313-.727-.777-.727zm7.953.454c0 1.302 4.582.202 4.592 3.714 0 1.756-1.171 2.967-3.512 2.967-1.413 0-2.604-.333-3.492-.938l.888-1.938c.676.525 1.524.898 2.675.898.777 0 1.15-.302 1.15-.716 0-1.443-4.622-.051-4.612-3.795.01-1.463 1.312-2.775 3.552-2.775 1.272 0 2.523.242 3.502.867l-.837 1.928c-.919-.615-1.867-.908-2.735-.888-.656.02-1.171.212-1.171.676");
		builder.CloseElement();
		builder.CloseElement();
    }
}
