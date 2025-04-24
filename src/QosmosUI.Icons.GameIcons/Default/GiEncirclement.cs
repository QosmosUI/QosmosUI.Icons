// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiEncirclement : ComponentBase
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
		builder.AddAttribute(14, "d", "M204.732 38.031L64 64l43.873 21.793C60.785 127.065 31 187.623 31 255c0 124.05 100.95 225 225 225s225-100.95 225-225c0-67.377-29.785-127.935-76.873-169.207L448 64 307.268 38.031 370.932 166.2l9.834-53.299C420.17 147.503 445 198.28 445 255c0 104.595-84.405 189-189 189S67 359.595 67 255c0-56.721 24.83-107.497 64.234-142.1l9.834 53.3zm73.994 81.127c-8.391 0-15 6.61-15 15 0 8.391 6.609 15 15 15 8.39 0 15-6.609 15-15 0-8.39-6.61-15-15-15zm-75.369 68.498c-8.39 0-15 6.61-15 15 0 8.391 6.61 15 15 15 8.391 0 15-6.609 15-15 0-8.39-6.609-15-15-15zm129.14-15.232c-8.39 0-15 6.61-15 15 0 8.391 6.61 15 15 15 8.392 0 15-6.609 15-15 0-8.39-6.608-15-15-15zm-205.29 35.611c-8.39 0-15 6.61-15 15 0 8.391 6.61 15 15 15s15-6.609 15-15c0-8.39-6.61-15-15-15zm123.602 23.988c-8.391 0-15 6.61-15 15 0 8.391 6.609 15 15 15 8.39 0 15-6.609 15-15 0-8.39-6.61-15-15-15zm51.687 6.817c-8.39 0-15 6.609-15 15 0 8.39 6.61 15 15 15 8.391 0 15-6.61 15-15 0-8.391-6.609-15-15-15zm72.455 11.834c-8.39 0-15 6.609-15 15 0 8.39 6.61 15 15 15 8.391 0 15-6.61 15-15 0-8.391-6.609-15-15-15zm-197.097 20.273c-8.391 0-15 6.61-15 15 0 8.391 6.609 15 15 15 8.39 0 15-6.609 15-15 0-8.39-6.61-15-15-15zm75.447 29.637c-8.391 0-15 6.61-15 15s6.609 15 15 15c8.39 0 15-6.61 15-15s-6.61-15-15-15zm96.442 15.343c-8.39 0-15 6.609-15 15 0 8.39 6.61 15 15 15 8.391 0 15-6.61 15-15 0-8.391-6.609-15-15-15zm-186.355 33.08c-8.39 0-15 6.609-15 15 0 8.39 6.61 15 15 15 8.391 0 15-6.61 15-15 0-8.391-6.609-15-15-15zm109.116 24.382c-8.391 0-15 6.609-15 15 0 8.39 6.609 15 15 15 8.39 0 15-6.61 15-15 0-8.391-6.61-15-15-15z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
