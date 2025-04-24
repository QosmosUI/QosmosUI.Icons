// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiFries : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Fries");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M19.51,9.535a1.091,1.091,0,0,0-.81-.36H17.67a.5.5,0,0,0-.17.02V4.815a1.5,1.5,0,0,0-1.5-1.5h-.5a1.3,1.3,0,0,0-.52.1,1.474,1.474,0,0,0-1.48-1.35H13a1.5,1.5,0,0,0-1.5,1.5v1.59a1.386,1.386,0,0,0-.5-.09h-.5a1.348,1.348,0,0,0-.5.09v-.34a1.5,1.5,0,0,0-1.5-1.5H8a1.5,1.5,0,0,0-1.5,1.5V9.2a.5.5,0,0,0-.17-.02H5.3a1.1,1.1,0,0,0-1.08,1.2l.85,8.98a2.84,2.84,0,0,0,2.84,2.58h8.18a2.84,2.84,0,0,0,2.84-2.58l.85-8.98A1.112,1.112,0,0,0,19.51,9.535ZM15,4.815a.5.5,0,0,1,.5-.5H16a.5.5,0,0,1,.5.5v6.14h.01A2.915,2.915,0,0,1,15,13.015Zm-2.5,8.53V3.565a.5.5,0,0,1,.5-.5h.5a.5.5,0,0,1,.5.5v9.76Zm-2.5-.02V6.565a.5.5,0,0,1,.5-.5H11a.5.5,0,0,1,.5.5v6.78ZM7.5,4.815a.5.5,0,0,1,.5-.5h.5a.5.5,0,0,1,.5.5v8.2a2.877,2.877,0,0,1-1.5-2.06Zm11.29,5.391-.85,9.049a1.85,1.85,0,0,1-1.85,1.68H7.91a1.84,1.84,0,0,1-1.84-1.68l-.86-9.08H6.33a.1.1,0,0,1,.09.08l.05.56a3.891,3.891,0,0,0,3.88,3.53h3.3a3.884,3.884,0,0,0,3.88-3.53l.05-.56a.106.106,0,0,1,.09-.08Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
