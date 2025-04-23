// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiCannon : ComponentBase
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
		builder.AddAttribute(14, "d", "M142.373 116.285l-15.92 9.79 19.223 31.257c-17.208 13.06-28.326 33.725-28.326 56.994 0 21.555 9.55 40.866 24.632 53.977l-71.76 92.16L20.66 379.69v17.828h71.834l73.588-95.78h8.22c-5.383 42.56 21.434 83.807 63.995 95.21 46.448 12.447 94.437-15.26 106.883-61.708 3.015-11.253 3.667-22.595 2.273-33.502h35.3v-30.61l109.858-7.968v-96.365l-286.655-21.91c-5.48-1.345-11.2-2.072-17.094-2.072-9.53 0-18.62 1.88-26.934 5.265l-19.553-31.793zM260.637 244.04c5.936-.01 11.978.757 17.998 2.37 36.692 9.832 58.323 47.3 48.492 83.992-9.832 36.692-47.3 58.326-83.992 48.494-36.692-9.83-58.326-47.3-48.494-83.992 7.99-29.812 34.222-49.684 63.46-50.814.843-.033 1.69-.05 2.537-.05zm3.633 19.747l-8.225 30.697-22.47-22.47-13.216 13.215 22.47 22.47-30.695 8.226 4.838 18.053 30.695-8.226-8.225 30.695 18.053 4.835 8.225-30.693 22.47 22.47 13.214-13.216-22.468-22.47 30.695-8.226-4.837-18.052-30.695 8.224 8.224-30.697-18.052-4.838z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
