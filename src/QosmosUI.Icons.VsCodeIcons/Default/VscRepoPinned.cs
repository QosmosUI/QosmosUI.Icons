// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscRepoPinned : ComponentBase
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
		builder.AddAttribute(14, "d", "M5 9H6V8H5V9ZM3.45 13.94C3.269 13.865 3.125 13.721 3.05 13.54C3.018 13.447 3.001 13.349 3 13.25V12.75C3.001 12.651 3.018 12.553 3.05 12.46C3.125 12.279 3.269 12.135 3.45 12.06C3.541 12.02 3.64 12 3.74 12H11.882L11.382 11H4V3H9.691C9.761 2.945 9.827 2.886 9.901 2.834C9.691 2.602 9.514 2.347 9.374 2.069C9.363 2.047 9.359 2.022 9.348 1.999H3.74C3.511 2.002 3.284 2.046 3.07 2.129C2.855 2.225 2.661 2.362 2.499 2.534C2.338 2.706 2.212 2.908 2.13 3.129C2.048 3.326 2.004 3.536 2 3.749V13.249C1.998 13.479 2.042 13.707 2.13 13.919C2.307 14.346 2.645 14.687 3.07 14.869C3.284 14.952 3.511 14.997 3.74 14.999H4V13.999H3.74C3.64 13.999 3.541 13.98 3.45 13.94ZM6 6H5V7H6V6ZM13 12.236V14H9V15H13.5L14 14.5V10.236L13 12.236ZM5 16H5.28L6.5 14.49L7.72 16H8V13H5V16ZM6 4H5V5H6V4ZM15.859 5.516C15.77 5.198 15.638 4.904 15.461 4.633C15.284 4.362 15.073 4.117 14.828 3.899C14.583 3.681 14.307 3.498 14 3.352V2.493C14.323 2.248 14.57 1.957 14.742 1.618C14.914 1.279 15 0.906999 15 0.500999V0.000999451H10V0.500999C10.005 0.906999 10.094 1.28 10.266 1.618C10.438 1.957 10.683 2.248 11 2.493V3.352C10.688 3.498 10.409 3.68 10.164 3.899C9.919 4.118 9.711 4.365 9.539 4.641C9.367 4.917 9.234 5.211 9.141 5.524C9.048 5.837 9 6.162 9 6.501V7.001H12V10.001L12.5 11.001L13 10.001V7.001H16V6.501C15.995 6.162 15.948 5.834 15.859 5.517V5.516ZM10.055 6C10.144 5.573 10.331 5.195 10.617 4.867C10.903 4.539 11.252 4.302 11.664 4.156L12 4.039V1.938C11.901 1.876 11.802 1.813 11.703 1.75C11.604 1.687 11.518 1.622 11.445 1.555C11.372 1.487 11.304 1.409 11.242 1.321C11.18 1.232 11.127 1.126 11.086 1.001H13.914C13.878 1.126 13.825 1.233 13.758 1.321C13.69 1.41 13.62 1.49 13.547 1.563C13.474 1.636 13.391 1.701 13.297 1.758C13.203 1.815 13.104 1.875 13 1.938V4.04L13.336 4.157C13.747 4.303 14.096 4.54 14.383 4.868C14.67 5.196 14.857 5.574 14.945 6.001H10.054L10.055 6Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
