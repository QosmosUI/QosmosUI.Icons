// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiDashlane : ComponentBase
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
		builder.AddAttribute(15, "d", "M20.89 7.7189c0-.1488-.1488-.2976-.3575-.3571l-2.502-.9221c-.4166-.1786-.8932.0297-.8932.3277V17.25c0 .1487.1488.3273.2977.3868l2.5614.9222c.3872.1487.8936-.0596.8936-.3873zm-4.676-3.663c0-.1492-.1489-.298-.3576-.3575l-2.5015-.9221c-.417-.1786-.8936.0297-.8936.3278v6.3723c0 .1488.1487.3273.2976.3873l2.5614.9221c.3873.1492.8937-.0595.8937-.3869zm0 11.4663c0-.1488-.1489-.2975-.3576-.3571l-2.5015-.9221c-.417-.1786-.8936.0297-.8936.3277v6.3724c0 .1488.1487.3273.2976.3869l2.5614.922c.3873.1493.8937-.0594.8937-.3872zm-4.6761 1.281c0-.1489-.1488-.298-.3575-.3576l-2.5015-.9221c-.4192-.1786-.8937.0297-.8937.3277v6.7903c0 .1487.1488.3277.2977.3872l2.5614.9222c.3872.1493.8936-.0595.8936-.387zm0-15.4579c0-.1488-.1488-.2976-.3575-.3571L8.6789.066c-.4192-.1786-.8937.0297-.8937.3277v6.7903c0 .1492.1488.3277.2977.3873l2.5614.922c.3872.1488.8936-.0594.8936-.3872zm-4.6752.2683c0-.1488-.1488-.298-.3575-.3576L4.0037.334C3.5867.1553 3.11.3636 3.11.6617v21.7409c0 .1487.1488.3273.298.3868l2.561.9222c.3874.1488.8937-.0595.8937-.3874z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
