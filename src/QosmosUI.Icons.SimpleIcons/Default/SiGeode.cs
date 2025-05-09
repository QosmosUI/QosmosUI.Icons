// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiGeode : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0c-.30206 0-.60438.09583-.85742.28906L.5957 8.34375c-.4705.3593-.66703.97346-.49218 1.53906l4.05664 13.1211c.1829.59168.7303.99609 1.3496.99609h12.98047c.61931 0 1.1667-.40441 1.34961-.9961l4.05664-13.12109c.17485-.5656-.02168-1.17975-.49218-1.53906l-.97266-.74219-1.11914 3.51758-3.07031 9.99024c-.12005.3903-.48032.65624-.88868.65624H6.57813c-.40836 0-.76863-.26593-.88868-.65624l-3.36132-10.9336c-.11419-.37133.01411-.77514.32226-1.01172l8.74805-6.7168a.93.93 0 0 1 .10937-.07226L13.55273.82031l-.6953-.53125C12.60437.09583 12.30205 0 12 0m.06836 4.75781c-.16254 0-.32493.05197-.46094.15625l-6.52344 5.0039c-.25142.19277-.35688.52145-.26367.82423l.4336 1.4082 2.19726-1.61914 4.31445-3.37695c.13717-.10727.33159-.10727.46875 0l4.70508 3.68164c.12315.09628.17407.25661.1289.40625l-1.80858 5.99219c-.0483.15993-.19619.26953-.36329.26953H9.10352a.377.377 0 0 1-.07618-.0078H6.9004l.42774 1.39257c.0979.3179.39196.53516.7246.53516h8.0332c.33265 0 .62477-.21725.72266-.53516l2.50977-8.14648c.09321-.30278-.01225-.63146-.26367-.82422l-6.5254-5.00392c-.136-.10428-.29839-.15625-.46093-.15625Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
