// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSellCard : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M128 32l-80 96h48v80h64v-80h48l-80-96zm224 0v80h-48l80 96 80-96h-48V32h-64zm80.096 204.904c-5.28.12-10.212 2.417-16.94 9.596l-6.562 6.969-6.813-6.72c-7.387-7.28-13.216-9.29-19.125-9.03-5.908.26-12.855 3.365-20.625 9.654l-6.219 5.031-5.906-5.375c-8.9-8.052-16.485-10.437-23.75-10.062-5.288.274-10.775 2.266-16.25 5.75l40.969 73.687c15.454 9.452 47.033 13.009 68.75 2.065l39.594-73.346c-7.51-3.062-14.26-6.2-20.094-7.404-2.112-.437-4.073-.758-5.97-.815-.355-.01-.71-.008-1.06 0zM88 240c-40 0-40 0-40 40v160.055C48 480 48 480 88 480h80c40 0 40 0 40-40V280c0-40 0-40-40-40H88zm254.125 93.094v.002C324.09 345.838 309.609 367.813 304 400c-5.435 31.196 3.127 52.264 18.281 66.623 15.155 14.36 37.902 21.738 61 21.438 23.1-.3 46.136-8.31 61.625-22.936 15.49-14.627 24.251-35.425 19.283-65.188-5.137-30.757-18.401-52.147-35.191-65.093-28.482 15.056-64.093 11.856-86.873-1.75z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
