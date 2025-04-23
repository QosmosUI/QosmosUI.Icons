// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiMailtrap : ComponentBase
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
		builder.AddAttribute(15, "d", "M5.37146 17.60681 3.33477 18.8148c-.27629.18168-.15004.49398 0 .55693l7.90979 4.43194c.46722.26178 1.04287.26178 1.51009 0l8.01458-4.49068c.24282-.14382.20298-.43614 0-.53479l-2.15348-1.16353c-.18174-.11994-.58711-.08004-.73069.01758l-5.13041 2.87463c-.46722.26178-1.04287.26178-1.51009 0l-5.17584-2.90007c-.19295-.11868-.4986-.11196-.69726 0ZM11.24492.19634c.46722-.26179 1.04281-.26179 1.51003 0l6.36966 3.56896c.25428.12865.27732.47404 0 .62979-.41988.23442-.98311.54855-1.45045.80916-.54595.30446-1.21057.30357-1.75592-.00201l-3.16329-1.7724c-.46722-.26179-1.04281-.26179-1.51003 0l-3.16701 1.7745c-.54577.30577-1.21096.30634-1.75727.00163-.48583-.27097-1.07519-.59951-1.49988-.83566-.23557-.10117-.28461-.40149 0-.57448L11.24492.19634Zm10.72402 5.37209c.46723.26179.75505.74561.75505 1.26917v10.32526c0 .51102-.32004.60637-.66139.42786l-2.3588-1.27315V9.37593l-6.94878 3.8935c-.46722.26178-1.04281.26178-1.51003 0l-6.94881-3.8935v6.9408L2.1528 17.58922c-.25545.16242-.87679.2136-.87679-.42636V6.8376c0-.52356.28782-1.00739.75504-1.26917.75174-.39366 1.52849 0 1.52849 0l8.44043 4.73955 8.42726-4.73955s.74839-.45137 1.54171 0Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
