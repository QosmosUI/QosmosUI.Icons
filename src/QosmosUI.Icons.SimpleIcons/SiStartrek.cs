// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiStartrek : ComponentBase
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
		builder.AddAttribute(15, "d", "M14.943 14.596c.094 0 .3.095.576.462a57.71 57.71 0 0 1 2.165 3.23c-1.627.646-3.595 1.01-5.684 1.01-.988 0-1.948-.097-2.856-.26 1.417-1.507 2.918-2.856 4.703-3.98.555-.278.819-.462 1.096-.462zm2.424-6.202c2.858 1.055 4.788 2.906 4.788 4.998 0 1.415-.881 2.73-2.338 3.755-.385-2.26-.898-4.477-1.644-6.616a38.69 38.69 0 0 0-.808-2.136zM7.73 8.077a38.965 38.965 0 0 0-1.096 3.288 56.361 56.361 0 0 0-1.327 6.404c-2.11-1.1-3.462-2.69-3.462-4.385.001-2.274 2.44-4.337 5.885-5.307zM12.463.086c-.095 0-.08-.007-.174.086a25.88 25.88 0 0 0-3.663 5.77C3.631 6.89 0 9.887 0 13.385c0 2.588 1.991 4.903 5.048 6.317a64.85 64.85 0 0 0-.347 4.01c0 .094.108.202.203.202h.086c.094 0 .08.007.173-.086a79.757 79.757 0 0 1 2.538-3.203c1.338.336 2.78.52 4.299.52 2.455 0 4.738-.48 6.635-1.298.46.772.908 1.555 1.385 2.395 0 .094.194.086.288.086a.175.175 0 0 0 .173-.173 69.569 69.569 0 0 0-.346-3.088c2.369-1.42 3.865-3.45 3.865-5.682 0-3.252-3.156-6.072-7.615-7.212a33.526 33.526 0 0 0-3.75-6c0-.094-.078-.087-.172-.087z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
