// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscRepoClone : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M13 9V11H4V3H8V2H3.74C3.511 2.003 3.284 2.047 3.07 2.13C2.855 2.226 2.661 2.363 2.499 2.535C2.338 2.707 2.212 2.909 2.13 3.13C2.048 3.327 2.004 3.537 2 3.75V13.25C1.998 13.48 2.042 13.708 2.13 13.92C2.307 14.347 2.645 14.688 3.07 14.87C3.284 14.953 3.511 14.998 3.74 15H4V14H3.74C3.64 14 3.541 13.98 3.45 13.94C3.269 13.865 3.125 13.721 3.05 13.54C3.018 13.447 3.001 13.349 3 13.25V12.75C3.001 12.651 3.018 12.553 3.05 12.46C3.125 12.279 3.269 12.135 3.45 12.06C3.541 12.02 3.64 12 3.74 12H13V14H9V15H13.5L14 14.5V9H13ZM5 16H5.28L6.5 14.49L7.72 16H8V13H5V16ZM6 4H5V5H6V4ZM6 6H5V7H6V6ZM5 9H6V8H5V9ZM10 1H14.5L15 1.5V7.5L14.5 8H12V9H11V8H10C9.735 8 9.48 7.895 9.293 7.707C9.105 7.519 9 7.265 9 7V2C9 1.735 9.105 1.48 9.293 1.293C9.481 1.105 9.735 1 10 1ZM10.5 7H11V6H10.5C10.367 6 10.24 6.053 10.146 6.146C10.052 6.24 10 6.367 10 6.5C10 6.633 10.053 6.76 10.146 6.854C10.24 6.948 10.367 7 10.5 7ZM12 7H14V6H12V7ZM11 5H14V2H11V5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
