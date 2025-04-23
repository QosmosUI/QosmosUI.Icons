// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiCpu : ComponentBase
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
		builder.AddAttribute(14, "d", "M151 22v32h18V22h-18zm48 0v32h18V22h-18zm48 0v32h18V22h-18zm48 0v32h18V22h-18zm48 0v32h18V22h-18zM131.7 73L73 131.7v248.6l58.7 58.7h248.6l58.7-58.7V131.7L380.3 73H131.7zm60.3 46h128v18H192v-18zM22 151v18h32v-18H22zm436 0v18h32v-18h-32zm-339 32h274v146H119V183zm-97 16v18h32v-18H22zm436 0v18h32v-18h-32zm-321 2v110h238V201H137zM22 247v18h32v-18H22zm436 0v18h32v-18h-32zM22 295v18h32v-18H22zm436 0v18h32v-18h-32zM22 343v18h32v-18H22zm436 0v18h32v-18h-32zm-266 32h128v18H192v-18zm-41 83v32h18v-32h-18zm48 0v32h18v-32h-18zm48 0v32h18v-32h-18zm48 0v32h18v-32h-18zm48 0v32h18v-32h-18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
