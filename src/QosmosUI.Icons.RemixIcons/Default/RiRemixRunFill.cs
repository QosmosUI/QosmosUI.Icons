// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiRemixRunFill : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M19.1155 20C19.1155 18.9358 19.1155 17.9609 18.9536 15.8812C18.7532 13.7919 17.6654 12.7329 15.8047 12.3608C18.0089 12.0746 19.6406 10.3574 19.6406 7.72423C19.6406 4.20384 17.3219 2 12.6558 2H4V5.66888H11.797C13.8581 5.66888 14.8887 6.55343 14.8887 8.0131C14.8887 9.67314 13.8581 10.3001 11.797 10.3001H4V14.0495H11.568C13.1997 14.0495 14.0871 14.5074 14.2302 16.5682C14.3385 17.9756 14.325 18.6726 14.3119 19.341L14.3119 19.3438C14.3077 19.5579 14.3036 19.7692 14.3036 20L19.1155 20ZM4 17.2046V19.9996H10.1222V18.2108C10.1222 17.8349 9.93768 17.2046 9.08783 17.2046H4Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
