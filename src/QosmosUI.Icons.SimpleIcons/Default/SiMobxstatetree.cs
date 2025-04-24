// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiMobxstatetree : ComponentBase
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
		builder.AddAttribute(15, "d", "M12.4359.5918c-.5327.0013-1.073.2715-1.432.8068L.3056 17.5528c-.9402 1.9806.4223 3.8737 2.2691 4.4105 3.469.7726 6.646-1.2927 6.646-1.2927 4.68-2.9945 7.7024-4.6851 7.7024-4.6851 3.7297-1.8907 6.9926.4293 6.9995.4342L13.8248 1.3986c-.3309-.54-.8563-.808-1.389-.8068zm.0043 1.6599c.4191-.0013.8326.2102 1.093.635 2.4662 3.6608 5.2689 7.4349 7.6288 11.1616 0 0-2.252-1.1721-5.19.3173 0 0-2.3795 1.3306-6.0622 3.687 0 0-2.4992 1.6244-5.229 1.0164-1.4534-.4224-2.5263-1.9125-1.7865-3.4711l8.4195-12.7111c.2825-.4212.7072-.6342 1.1264-.6351zM20.86 16.4169c-4.0347.0998-7.5355 3.8695-10.387 4.9836 4.3352 5.2103 17.3143-.9708 12.454-4.4241-.6166-.4203-1.315-.578-2.067-.5595zm-.0247 1.0159c.5446.003 1.04.1454 1.4567.4783 2.288 2.2856-6.3047 6.2616-9.9585 3.647 1.1813-.0912 5.5606-4.1413 8.5018-4.1253Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
