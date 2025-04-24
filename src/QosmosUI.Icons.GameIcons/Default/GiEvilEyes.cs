// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiEvilEyes : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M74.247 167.854C-90.602 374.671 219.872 342.307 219.872 342.307 138.961 289.214 74.247 167.854 74.247 167.854zm5.027 140.538c-8.384-13.955-4.365-37.814 11.23-68.749 3.447 4.516 7.256 9.333 11.335 14.406l19.178 62.17 7.346-31.115a561.216 561.216 0 0 0 50.158 49.33c-51.874 1.67-88.197-7.677-99.247-26.027zm358.494-140.538s-64.729 121.36-145.625 174.453c-.015 0 310.459 32.364 145.61-174.453zm-5.028 140.538c-11.049 18.38-47.372 27.713-99.246 26.072a561.276 561.276 0 0 0 50.158-49.33l7.33 31.085 19.179-62.215a733.836 733.836 0 0 0 11.335-14.406c15.595 30.995 19.66 54.84 11.23 68.809z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
