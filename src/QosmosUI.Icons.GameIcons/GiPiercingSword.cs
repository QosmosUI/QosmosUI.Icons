// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiPiercingSword : ComponentBase
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
		builder.AddAttribute(14, "d", "M40.598 20.316c-11.602 0-21.008 9.406-21.008 21.008 0 11.602 9.406 21.006 21.008 21.006 1.788 0 3.524-.226 5.18-.646l54.972 54.97-46.223 46.223 46.924 65.783 15.216-10.85-28.316-39.7 18.29-18.29 186.083 272.387 2.203 1.084c53.664 26.42 111.6 49.15 183.537 58.05l11.496 1.424-1.044-11.54c-6.375-70.503-30.856-128.572-58.082-183.845l-1.088-2.21L157.08 109.38l18.432-18.433 39.586 28.395 10.892-15.186-65.652-47.09-46.373 46.373-53.992-53.993c1.05-2.5 1.63-5.242 1.63-8.123 0-11.602-9.404-21.008-21.005-21.008zM143.63 122.828l271.49 184.988c.395.807.78 1.617 1.175 2.424l-9.844 28.38-259.538-191.436L338.066 406.8l-33.15 10.13-184.83-270.557 23.545-23.545zm127.327 147.45L418.13 379.3l11.85-49.017 37.204 135.32-135.317-37.205 49.014-11.856-109.923-146.26z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
