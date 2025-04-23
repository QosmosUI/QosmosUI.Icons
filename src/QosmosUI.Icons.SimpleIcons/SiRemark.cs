// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiRemark : ComponentBase
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
		builder.AddAttribute(15, "d", "M4.204 18.089V12.66q0-2.477 1.156-3.947 1.156-1.47 3.108-1.47.494 0 1.03.092.54.088.953.245V5.976q-.279-.122-.754-.195-.478-.073-1.007-.073-1.76 0-2.902.88-1.144.881-1.458 2.497h-.157V6.01H0v1.186h2.737V18.09Zm-3.959 0H8.04v-1.187H.245ZM19.1 7.109q1.604 0 2.507 1.095.904 1.091.904 3.02H15.6q0-1.94.93-3.027.93-1.088 2.569-1.088zm4.846 7.998h-1.458q-.28.884-1.133 1.378-.854.494-2.087.494-1.68 0-2.676-1.114-.991-1.118-.991-3.013v-.414H24v-.953q0-1.807-.578-3.074-.574-1.267-1.67-1.933-1.094-.67-2.652-.67-1.493 0-2.615.658-1.118.655-1.738 1.838-.617 1.183-.617 2.775v1.761q0 2.58 1.352 4.016 1.351 1.436 3.786 1.436 1.221 0 2.205-.394.98-.39 1.627-1.11.643-.717.846-1.681z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
