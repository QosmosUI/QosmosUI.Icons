// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiCodecrafters : ComponentBase
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
		builder.AddAttribute(15, "d", "M9.825 17.527a.111.111 0 0 1-.107-.142l3.05-10.837a.111.111 0 0 1 .108-.081H14.2c.074 0 .127.07.107.141l-3.063 10.838a.111.111 0 0 1-.107.08H9.825Zm-2.146-2.732a.11.11 0 0 1-.079-.033l-2.667-2.704a.111.111 0 0 1 0-.156L7.6 9.211a.111.111 0 0 1 .08-.033h1.702c.1 0 .149.12.079.19l-2.534 2.534a.111.111 0 0 0 0 .157l2.535 2.546c.07.07.02.19-.079.19H7.68Zm6.954 0a.111.111 0 0 1-.079-.19l2.525-2.546a.111.111 0 0 0 0-.157l-2.524-2.535a.111.111 0 0 1 .079-.19h1.692c.03 0 .058.013.078.034l2.68 2.69a.111.111 0 0 1 0 .157l-2.68 2.704a.111.111 0 0 1-.078.033h-1.693ZM12 24C5.383 24 0 18.617 0 12S5.383 0 12 0s12 5.383 12 12-5.383 12-12 12Zm0-22.667C6.118 1.333 1.333 6.118 1.333 12S6.118 22.667 12 22.667 22.667 17.882 22.667 12 17.882 1.333 12 1.333Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
