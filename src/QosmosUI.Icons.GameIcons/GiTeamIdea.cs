// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiTeamIdea : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 16c-48 0-80 32-80 64 0 48 16 80 32 96v16h96v-16c16-16 32-48 32-96 0-32-32-64-80-64zm-63.6 65.33L256 102.5l63.6-21.17-39.2 97.97-16.8-6.6 24.8-62-32.4 10.8-32.4-10.8 24.8 62-16.8 6.6-39.2-97.97zm-83.3 79.07c-23.4 3-44.6 30.5-44.6 65.9 0 19.6 6.8 36.9 16.7 48.9l11.9 14.2-18.3 3.4c-12.9 2.5-22.3 9.3-30.4 20.4-8.1 11.1-14.3 26.5-18.6 44.4C18 389.8 16.2 429.2 16 464h42.8l2.24 30H169.6l2-30h40.8c0-35.2-.4-75.1-7.5-107.7-4-17.9-9.9-33.3-18.1-44.3-8.2-11-18.1-17.8-32.6-20l-18.5-2.9 11.7-14.7c9.5-11.9 15.9-29 15.9-48.1 0-37.8-23.6-65.8-49.4-65.8l-4.8-.1zm283.6 0c-23.4 3-44.6 30.5-44.6 65.9 0 19.6 6.8 36.9 16.7 48.9l11.9 14.2-18.3 3.4c-12.9 2.5-22.3 9.3-30.4 20.4-8.1 11.1-14.3 26.5-18.6 44.4-7.8 32.2-9.6 71.6-9.8 106.4h42.8l2.2 30h108.6l2-30H496c0-35.2-.4-75.1-7.5-107.7-4-17.9-9.9-33.3-18.1-44.3-8.2-11-18.1-17.8-32.6-20l-18.5-2.9 11.7-14.7c9.5-11.9 15.9-29 15.9-48.1 0-37.8-23.6-65.8-49.4-65.8l-4.8-.1zM208 209v18h96v-18h-96zm16 34v18h64v-18h-64z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
