// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImGrin2 : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M8 0c-4.418 0-8 3.582-8 8s3.582 8 8 8c4.418 0 8-3.582 8-8s-3.582-8-8-8zM11 3.688c0.999 0 1.813 0.813 1.813 1.813 0 0.1-0.009 0.201-0.025 0.302-0.025 0.151-0.156 0.261-0.308 0.261s-0.283-0.11-0.308-0.261c-0.096-0.573-0.589-0.833-1.171-0.833s-1.074 0.26-1.171 0.833c-0.025 0.151-0.156 0.261-0.308 0.261-0 0 0 0-0 0-0.153 0-0.283-0.11-0.308-0.261-0.017-0.101-0.025-0.202-0.025-0.302 0-0.999 0.813-1.813 1.813-1.813zM5 3.688c0.999 0 1.813 0.813 1.813 1.813 0 0.1-0.009 0.201-0.025 0.302-0.025 0.151-0.156 0.261-0.308 0.261s-0.283-0.11-0.308-0.261c-0.096-0.573-0.589-0.833-1.171-0.833s-1.074 0.26-1.171 0.833c-0.025 0.151-0.156 0.261-0.308 0.261 0 0 0 0 0 0-0.153 0-0.283-0.11-0.308-0.261-0.017-0.101-0.025-0.202-0.025-0.302 0-0.999 0.813-1.813 1.813-1.813zM3 9h3v3.873c-1.72-0.447-3-2.018-3-3.873zM7 13v-4h2v4h-2zM10 12.873v-3.873h3c0 1.855-1.28 3.426-3 3.873z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
