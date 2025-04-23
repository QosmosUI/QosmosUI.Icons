// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Logo;

public class BiLogoBxlSlack : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.AddAttribute(14, "d", "M6.194 14.644c0 1.16-.943 2.107-2.103 2.107a2.11 2.11 0 0 1-2.104-2.107 2.11 2.11 0 0 1 2.104-2.106h2.103v2.106zm1.061 0c0-1.16.944-2.106 2.104-2.106a2.11 2.11 0 0 1 2.103 2.106v5.274a2.11 2.11 0 0 1-2.103 2.106 2.108 2.108 0 0 1-2.104-2.106v-5.274zm2.104-8.455c-1.16 0-2.104-.948-2.104-2.107s.944-2.106 2.104-2.106a2.11 2.11 0 0 1 2.103 2.106v2.107H9.359zm0 1.06a2.11 2.11 0 0 1 2.103 2.107 2.11 2.11 0 0 1-2.103 2.106H4.092a2.11 2.11 0 0 1-2.104-2.106 2.11 2.11 0 0 1 2.104-2.107h5.267zm8.447 2.107c0-1.16.943-2.107 2.103-2.107a2.11 2.11 0 0 1 2.104 2.107 2.11 2.11 0 0 1-2.104 2.106h-2.103V9.356zm-1.061 0c0 1.16-.944 2.106-2.104 2.106a2.11 2.11 0 0 1-2.103-2.106V4.082a2.11 2.11 0 0 1 2.103-2.106c1.16 0 2.104.946 2.104 2.106v5.274zm-2.104 8.455c1.16 0 2.104.948 2.104 2.107s-.944 2.106-2.104 2.106a2.11 2.11 0 0 1-2.103-2.106v-2.107h2.103zm0-1.06a2.11 2.11 0 0 1-2.103-2.107 2.11 2.11 0 0 1 2.103-2.106h5.268a2.11 2.11 0 0 1 2.104 2.106 2.11 2.11 0 0 1-2.104 2.107h-5.268z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
