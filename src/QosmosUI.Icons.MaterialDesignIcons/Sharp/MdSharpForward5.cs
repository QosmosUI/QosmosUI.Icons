// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Sharp;

public class MdSharpForward5 : ComponentBase
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
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M17.95 13c0 3.31-2.69 6-6 6s-6-2.69-6-6 2.69-6 6-6v4l5-5-5-5v4c-4.42 0-8 3.58-8 8s3.58 8 8 8 8-3.58 8-8h-2zm-5.52 2.15c-.05.07-.11.13-.18.17s-.17.06-.27.06c-.17 0-.31-.05-.42-.15s-.17-.24-.19-.41h-.84c.01.2.05.37.13.53s.19.28.32.39.29.19.46.24.35.08.53.08c.24 0 .46-.04.64-.12s.33-.18.45-.31.21-.28.27-.45.09-.35.09-.54c0-.22-.03-.43-.09-.6s-.14-.33-.25-.45-.25-.22-.41-.28-.34-.1-.55-.1c-.07 0-.14.01-.2.02s-.13.02-.18.04-.1.03-.15.05-.08.04-.11.05l.11-.92h1.7v-.71H10.9l-.25 2.17.67.17c.03-.03.06-.06.1-.09s.07-.05.12-.07.1-.04.15-.05.13-.02.2-.02c.12 0 .22.02.3.05s.16.09.21.15.1.14.13.24.04.19.04.31-.01.22-.03.31-.06.17-.11.24z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
