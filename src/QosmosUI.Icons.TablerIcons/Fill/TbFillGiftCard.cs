// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillGiftCard : ComponentBase
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
		builder.AddAttribute(14, "d", "M18 4a4 4 0 0 1 3.995 3.8l.005 .2v8a4 4 0 0 1 -3.8 3.995l-.2 .005h-12a4 4 0 0 1 -3.995 -3.8l-.005 -.2v-8a4 4 0 0 1 3.8 -3.995l.2 -.005h12zm-5.493 5l-.19 .004c-.928 .052 -1.719 .583 -2.317 1.444c-.56 -.805 -1.288 -1.322 -2.139 -1.428l-.198 -.017l-.164 -.003l-.16 .005c-1.28 .086 -2.339 1.179 -2.339 2.495c0 1.226 1.222 2.211 2.453 2.447l.16 .026l-1.32 1.32l-.083 .094a1 1 0 0 0 0 1.226l.083 .094l.094 .083a1 1 0 0 0 1.226 0l.094 -.083l2.293 -2.292l2.293 2.292l.094 .083a1 1 0 0 0 1.403 -1.403l-.083 -.094l-1.32 -1.32c1.229 -.169 2.502 -1.11 2.606 -2.315l.007 -.158l-.005 -.163c-.08 -1.189 -1.02 -2.162 -2.175 -2.316l-.159 -.016l-.154 -.005zm-.025 2l.102 .009c.194 .04 .367 .21 .407 .406l.009 .085l-.012 .031l-.034 .04c-.13 .135 -.513 .369 -.836 .42l-.118 .009h-.602l.052 -.1l.088 -.156c.27 -.444 .574 -.696 .852 -.738l.092 -.006zm-4.964 0l.084 .005l.094 .02c.254 .077 .523 .32 .765 .718l.09 .157l.05 .1h-.601l-.106 -.008c-.398 -.057 -.894 -.4 -.894 -.492c0 -.23 .194 -.446 .416 -.491l.102 -.01z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
